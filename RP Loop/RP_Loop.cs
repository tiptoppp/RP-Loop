using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System;
using MemoryNoAdmin;

namespace RP_Loop
{
    public partial class RPLoopForm : Form
    {
        public Mem MemLib = new Mem();
        private bool ProcOpen = false;
        private Process GTAV = null;

        public RPLoopForm()
        {
            InitializeComponent();
            Task.Run(() =>
            {
                while (true)
                {
                    if (GTAV != null)
                    {
                        if (GTAV.HasExited)
                        {
                            GTAV = null;
                            ProcOpen = false;
                        }
                    }
                    Task task = AttemptOpenProcess();
                }
            });
        }

        CancellationTokenSource _cts = null;
        private bool Connect = false;

        private async Task AttemptOpenProcess()
        {
            if (!ProcOpen && !Connect)
            {
                Connect = true;
                if (MemLib.OpenProcess("GTA5"))
                {
                    ProcOpen = true;
                    await ConnectWorld();
                    GTAV = MemLib.mProc.Process;
                }
                Connect = false;
            }
        }
        private string WorldAssemblyAddress = "";
        private string WorldBaseAddress = "";

        private string WorldPlayersBaseAddress => MemLib.ReadLong(WorldBaseAddress).ToString("X2");

        private string LocalPlayerAddress => MemLib.ReadLong(WorldPlayersBaseAddress + "+8").ToString("X2");

        private string LocalPlayerInfoAddress => MemLib.ReadLong(LocalPlayerAddress + "+10C8").ToString("X2");

        private string WantedOffset => (0x7D0 + 0xB8).ToString("X2");

        public int WantedLevel
        {
            get => MemLib.ReadInt(LocalPlayerInfoAddress + "+" + WantedOffset);
            set => MemLib.WriteMemory(LocalPlayerInfoAddress + "+" + WantedOffset, "int", value.ToString());
        }
        private string GlobalAssemblyAddress = "";
        private string GlobalBaseAddress = "";

        private string GlobalRP_Address => (MemLib.ReadLong(GlobalBaseAddress + "+8") + 0x10).ToString("X2");

        public float GlobalRPValue
        {
            get => MemLib.ReadFloat(GlobalRP_Address);
            set => MemLib.WriteMemory(GlobalRP_Address, "float", value.ToString());
        }
        private bool IsWorldConnectionAttempting = false;

        private async Task ConnectWorld()
        {
            if (!IsWorldConnectionAttempting)
            {
                IsWorldConnectionAttempting = true;
                var WorldHook = await MemLib.AoBScan(
                MemLib.mProc.MainModule.BaseAddress.ToInt64(),
                MemLib.mProc.MainModule.BaseAddress.ToInt64() + MemLib.mProc.MainModule.ModuleMemorySize,
                "48 8B 05 ?? ?? ?? ?? 45 ?? ?? ?? ?? 48 8B 48 08 48 85 C9 74 07", true, true, true, "");
                long Address = WorldHook[0];
                WorldAssemblyAddress = (Address.ToString("X2"));
                WorldBaseAddress = (Address + MemLib.ReadInt((Address + 3).ToString("X2")) + 7).ToString("X2");
                var GlobalHook = await MemLib.AoBScan(
                MemLib.mProc.MainModule.BaseAddress.ToInt64(),
                MemLib.mProc.MainModule.BaseAddress.ToInt64() + MemLib.mProc.MainModule.ModuleMemorySize,
                "48 8D 3D ?? ?? ?? 0? 80 3E", true, true, true, "");
                Address = GlobalHook[0];
                GlobalAssemblyAddress = (Address.ToString("X2"));
                GlobalBaseAddress = (Address + MemLib.ReadInt((Address + 3).ToString("X2")) + 7).ToString("X2");
            }
        }

        private async void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleRPLoopcheckBox.Checked)
            {
                GlobalRPValue = 500;
                _cts = new CancellationTokenSource();
                while (ToggleRPLoopcheckBox.Checked)
                {
                    try
                    {
                        await onTick(_cts.Token);
                        await Task.Delay(1000, _cts.Token);
                    }
                    catch (TaskCanceledException)
                    {
                        break;
                    }
                }
                ResetDefaults();
            }
            else
            {
                _cts?.Cancel();
            }
        }

        private void ResetDefaults()
        {
            GlobalRPValue = 1;
            WantedLevel = 0;
        }

        private async Task onTick(CancellationToken token)
        {
            WantedLevel = 1;
            await Task.Delay(1000, token);
            WantedLevel = 0;
        }

        private void AppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DiscordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discordapp.com/users/558009992473739289");
        }
    }
}
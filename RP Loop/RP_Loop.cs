using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Runtime.InteropServices;
using MemoryNoAdmin;
using MProcess;

namespace RP_Loop
{
    public partial class RPLoopForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();
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

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RPLoopForm_Load(object sender, EventArgs e)
        {
            searchingProcess1.Show();
            Timer.Enabled = true;
            Timer.Interval = 100;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ProcOpen == true)
            {
                searchingProcess1.Hide();
            }
        }

        private async Task SoloPublicLobby()
        {
            int pid = ProcessAccess.GetPidWithName("GTA5");
            ProcessAccess.SuspendProcess(pid);
            await Task.Delay(8000);
            ProcessAccess.ResumeProcess(pid);
        }

        private void EmptyLobby_Click(object sender, EventArgs e)
        {
            Task task = SoloPublicLobby();
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

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.Minimize_Hover;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Properties.Resources.Minimize;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackgroundImage = Properties.Resources.Exit_Hover;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackgroundImage = Properties.Resources.Exit;
        }

        private void DiscordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discordapp.com/users/558009992473739289");
        }
    }
}
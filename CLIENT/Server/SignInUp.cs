using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Server
{
    public partial class SignInUp : Form
    {
        #region Variables
        //variable
        private int number = 0;
        private int check = 0;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        #endregion

        #region Constructor
        //Constructor
        public SignInUp()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region KeyPress
        //Key press events
        private void SignInEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignInPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignUpFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignUpLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignUpEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignUpPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region MouseHover
        //Mouse hover events
        private void SignInButton_MouseHover(object sender, EventArgs e)
        {
            try
            {
                SignInButton.BackColor = Color.FromArgb(78, 140, 44);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignUpButton_MouseHover(object sender, EventArgs e)
        {
            try
            {
                SignUpButton.BackColor = Color.FromArgb(78, 140, 44);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region MouseLeave
        //Mouse leave events
        private void SignInButton_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                SignInButton.BackColor = Color.FromArgb(88, 205, 54);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignUpButton_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                SignUpButton.BackColor = Color.FromArgb(88, 205, 54);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region LinkClicked
        //helper
        private void SignUpLinkLabelClicked()
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(SignUpLinkLabelClicked));
                    return;
                }
                if (QrcodePanel.Visible == true)
                {
                    QrcodePanel.Visible = false;
                }
                SignInPanel.Visible = false;
                SignUpPanel.Visible = true;
                SignUpPanel.Left = 0;
                SignUpPanel.Top = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignInLinkLabelClicked()
        {
            try
            {
                SignInPanel.Visible = true;
                SignUpPanel.Visible = false;
                SignInPanel.Left = 0;
                SignInPanel.Top = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignInManuallyLinkLabelClicked()
        {
            try
            {
                QrCodeWebcam.Enabled = true;
                QrcodeWebcamPicturebox.Enabled = true;
                QrcodeCameraPresent.Visible = false;
                QrcodeStart.Visible = false;
                verifyQrcodePicturebox.Visible = false;
                if (videoCaptureDevice != null)
                {
                    videoCaptureDevice.Stop();
                }
                QrcodePanel.Visible = false;
                SignInPanel.Visible = true;
                SignInPanel.Left = 0;
                SignInPanel.Top = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Link clicked events
        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SignUpLinkLabelClicked();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SignInLinkLabelClicked();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SignInManuallyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SignInManuallyLinkLabelClicked();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region SignIn
        //helper function
        private void signInSuccessful()
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(signInSuccessful));
                    return;
                }
                this.Hide();
                var ClientPanel = new Client_Panel();
                ClientPanel.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //sign in Client helper
        private void SignInClient(string email, string password)
        {
            try
            {
                StreamReader ClientEmails = new StreamReader("../../../../Server/Server/Data/ClientData/ClientEmails.txt");
                StreamReader ClientNames = new StreamReader("../../../../Server/Server/Data/ClientData/ClientNames.txt");
                StreamReader ClientPasswords = new StreamReader("../../../../Server/Server/Data/ClientData/ClientPasswords.txt");
                string emails = "";
                string names = "";
                string passwords = "";
                bool signIn = false;
                while (!ClientEmails.EndOfStream)
                {
                    emails = ClientEmails.ReadLine();
                    names = ClientNames.ReadLine();
                    passwords = ClientPasswords.ReadLine();
                    if ((email == emails) && (password == passwords))
                    {
                        signIn = true;
                        break;
                    }
                }
                ClientEmails.Close();
                ClientNames.Close();
                ClientPasswords.Close();
                if (!signIn)
                {
                    MessageBox.Show("You are not sign up to our device.\nPlease sign up to out  device.");
                    SignUpLinkLabelClicked();
                }
                else
                {
                    if (videoCaptureDevice != null)
                    {
                        videoCaptureDevice.SignalToStop();
                    }
                    signInSuccessful();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Button click events
        private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidEmail(SignInEmail.Text))
                {
                    MessageBox.Show("Please enter a valid Email address!");
                }
                else if (SignInPassword.Text == "")
                {
                    MessageBox.Show("Please enter a non-empty Password!");
                }
                else
                {
                    string ClientEmail = SignInEmail.Text;
                    string ClientPassword = SignInPassword.Text;
                    if (isClientBlocked(ClientEmail))
                    {
                        MessageBox.Show("Your account was blocked!\nPlease contact our Client team for more actions!", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SignInClient(ClientEmail, ClientPassword);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Qr code Sign in
        private void SigninQrcodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                SignInPanel.Visible = false;
                QrcodePanel.Visible = true;
                QrcodePanel.Left = 0;
                QrcodePanel.Top = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Webcam qr
        private void QrCodeWebcam_Click(object sender, EventArgs e)
        {
            try
            {
                QrCodeWebcam.Enabled = false;
                QrcodeWebcamPicturebox.Enabled = false;
                QrcodeCameraPresent.Visible = true;
                QrcodeStart.Visible = true;
                verifyQrcodePicturebox.Visible = true;
                verifyQrcodePicturebox.Image = null;
                QrcodeCameraPresent.Items.Clear();
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo device in filterInfoCollection)
                {
                    QrcodeCameraPresent.Items.Add(device.Name);
                    QrcodeCameraPresent.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void QrcodeWebcamPicturebox_Click(object sender, EventArgs e)
        {
            try
            {
                QrCodeWebcam_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void QrcodevideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                BarcodeReader barReader = new BarcodeReader();
                var result = barReader.Decode(bitmap);
                verifyQrcodePicturebox.Image = bitmap;
                if (result != null)
                {
                    string[] results = result.ToString().Split('\n');
                    string email = results[0];
                    string password = results[1];
                    videoCaptureDevice.SignalToStop();
                    SignInClient(email, password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void QrcodeStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (QrcodeCameraPresent.SelectedIndex != -1)
                {
                    QrcodeCameraPresent.Visible = false;
                    QrcodeStart.Visible = false;
                    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[QrcodeCameraPresent.SelectedIndex].MonikerString);
                    videoCaptureDevice.NewFrame += QrcodevideoCaptureDevice_NewFrame;
                    videoCaptureDevice.Start();
                }
                else
                {
                    MessageBox.Show("Please select a valid index.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void QrcodeFilePicturebox_Click(object sender, EventArgs e)
        {
            try
            {
                QrcodeFile_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //File Qr
        private void QrcodeFile_Click(object sender, EventArgs e)
        {
            try
            {
                QrCodeWebcam.Enabled = true;
                QrcodeWebcamPicturebox.Enabled = true;
                QrcodeCameraPresent.Visible = false;
                QrcodeStart.Visible = false;
                verifyQrcodePicturebox.Visible = false;
                if (videoCaptureDevice != null)
                {
                    videoCaptureDevice.Stop();
                }
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap bitmap = new Bitmap(ofd.FileName);
                        BarcodeReader barReader = new BarcodeReader();
                        var result = barReader.Decode(bitmap);
                        if (result != null)
                        {
                            string[] results = result.ToString().Split('\n');
                            string email = results[0];
                            string password = results[1];
                            SignInClient(email, password);
                        }
                        else
                        {
                            MessageBox.Show("Qr code is empty!");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Qr code is invalid");
            }
        }
        #endregion

        #region ClientPB
        //Is Client Present
        private bool isClientPresent(string clientEmail)
        {
            try
            {
                StreamReader ClientEmails = new StreamReader("../../../../Server/Server/Data/ClientData/ClientEmails.txt");
                string ClientEmail = "";
                while (!ClientEmails.EndOfStream)
                {
                    ClientEmail = ClientEmails.ReadLine();
                    if (clientEmail == ClientEmail)
                    {
                        ClientEmails.Close();
                        return true;
                    }
                }
                ClientEmails.Close();
                return false;
            }
            catch
            {
                return false;
            }
        }
        //Is Client Blocked
        private bool isClientBlocked(string clientEmail)
        {
            try
            {
                StreamReader BlockedClientEmails = new StreamReader("../../../../Server/Server/Data/ClientData/BlockedClientEmails.txt");
                string ClientEmail = "";
                while (!BlockedClientEmails.EndOfStream)
                {
                    ClientEmail = BlockedClientEmails.ReadLine();
                    if ((clientEmail == ClientEmail))
                    {
                        BlockedClientEmails.Close();
                        return true;
                    }
                }
                BlockedClientEmails.Close();
                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region SignUp
        //Sign up
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidEmail(SignUpEmail.Text))
                {
                    MessageBox.Show("Please enter a valid Email address!");
                }
                else if (SignUpPassword.Text == "")
                {
                    MessageBox.Show("Please enter a non-empty Password!");
                }
                else if (SignUpFirstName.Text == "")
                {
                    MessageBox.Show("First name can't be empty!");
                }
                else if (SignUpLastName.Text == "")
                {
                    MessageBox.Show("Last name can't be empty!");
                }
                else
                {
                    string ClientEmail = SignUpEmail.Text;
                    string ClientName = SignUpFirstName.Text + " " + SignUpLastName.Text;
                    string ClientPassword = SignUpPassword.Text;
                    if (isClientBlocked(ClientEmail))
                    {
                        MessageBox.Show("Your account was blocked!\nPlease contact our Client team for more actions!", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (isClientPresent(ClientEmail))
                    {
                        MessageBox.Show("Your account is already present!\nPlease sign in.", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        SignInLinkLabelClicked();
                    }
                    else
                    {
                        Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                        string data = ClientEmail + "\n" + ClientPassword;
                        QrcodeMakePicturebox.Image = qrcode.Draw(data, 50);
                        Bitmap bmp = new Bitmap(QrcodeMakePicturebox.Width, QrcodeMakePicturebox.Height);
                        QrcodeMakePicturebox.DrawToBitmap(bmp, new Rectangle(0, 0, QrcodeMakePicturebox.Width, QrcodeMakePicturebox.Height));
                        bmp.Save(@"A:\DATA STRUCTURE\LAB\PROJECT\Final Project\Server\Server\Data\Pictures\Temp\Sign In Qr code.jpg");
                        bmp.Dispose();
                        SendEmail(ClientEmail, ClientName, ref number);
                        SignUpPanel.Visible = false;
                        VerificationPanel.Visible = true;
                        VerificationPanel.Left = 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region EmailOperations
        //Send Email to someone
        private void SendEmail(string ClientEmail, string ClientName, ref int number)
        {
            try
            {
                string from = "muhammad3245571106@gmail.com";
                string password = "awais9611";
                Random random = new Random();
                string text = "Hi, ";
                text += ClientName;
                text += "\nYour verification code is : ";
                int randomNumber = random.Next(100000, 999999);
                text += randomNumber.ToString();
                text += "\nPlease use it to verify your account.\nThanks!";
                text += "\n\nRegards!\nMuhammad Awais";
                MailMessage mailMessage = new MailMessage(from, ClientEmail, "Verifiy your email", text);
                mailMessage.Attachments.Add(new Attachment(@"A:\DATA STRUCTURE\LAB\PROJECT\Final Project\Server\Server\Data\Pictures\Temp\Sign In Qr code.jpg"));
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(from, password);
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);
                MessageBox.Show("E-mail sent successfully.");
                smtp.Dispose();
                mailMessage.Dispose();
                number = randomNumber;
            }
            catch
            {
                SendEmail(ClientEmail, ClientName, ref number);
            }
        }
        //Email Validation
        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region PasswordHideShow
        //Password hide or show
        private void HidePasswordPicture_Click(object sender, EventArgs e)
        {
            try
            {
                HidePasswordPicture.Visible = false;
                ShowPasswordPicture.Visible = true;
                SignInPassword.PasswordChar = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowPasswordPicture_Click(object sender, EventArgs e)
        {
            try
            {
                HidePasswordPicture.Visible = true;
                ShowPasswordPicture.Visible = false;
                SignInPassword.PasswordChar = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HidePasswordPicture2_Click(object sender, EventArgs e)
        {
            try
            {
                HidePasswordPicture2.Visible = false;
                ShowPasswordPicture2.Visible = true;
                SignUpPassword.PasswordChar = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowPasswordPicture2_Click(object sender, EventArgs e)
        {
            try
            {
                HidePasswordPicture2.Visible = true;
                ShowPasswordPicture2.Visible = false;
                SignUpPassword.PasswordChar = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Verification
        //helper
        private void verifyButtonClick()
        {
            try
            {
                if (number.ToString() == VerificationCode.Text)
                {
                    string ClientEmail = SignUpEmail.Text;
                    string ClientName = SignUpFirstName.Text + " " + SignUpLastName.Text;
                    string ClientPassword = SignUpPassword.Text;
                    StreamWriter PendingClientEmails = new StreamWriter("../../../../Server/Server/Data/ClientData/ClientEmails.txt", append: true);
                    StreamWriter PendingClientNames = new StreamWriter("../../../../Server/Server/Data/ClientData/ClientNames.txt", append: true);
                    StreamWriter PendingClientPasswords = new StreamWriter("../../../../Server/Server/Data/ClientData/ClientPasswords.txt", append: true);
                    PendingClientEmails.WriteLine(ClientEmail);
                    PendingClientNames.WriteLine(ClientName);
                    PendingClientPasswords.WriteLine(ClientPassword);
                    PendingClientEmails.Close();
                    PendingClientNames.Close();
                    PendingClientPasswords.Close();
                    MessageBox.Show("Your account is Verified!\n Please sign in to use faciliteis!");
                    SignInLinkLabelClicked();
                }
                else
                {
                    check++;
                }
                if (check == 5)
                {
                    string ClientEmail = SignUpEmail.Text;
                    string ClientName = SignUpFirstName.Text + " " + SignUpLastName.Text;
                    string ClientPassword = SignUpPassword.Text;
                    StreamWriter BlockedClientEmails = new StreamWriter("../../../../Server/Server/Data/ClientData/BlockedClientEmails.txt", append: true);
                    StreamWriter BlockedClientNames = new StreamWriter("../../../../Server/Server/Data/ClientData/BlockedClientNames.txt", append: true);
                    StreamWriter BlockedClientPasswords = new StreamWriter("../../../../Server/Server/Data/ClientData/BlockedClientPasswords.txt", append: true);
                    BlockedClientEmails.WriteLine(ClientEmail);
                    BlockedClientNames.WriteLine(ClientName);
                    BlockedClientPasswords.WriteLine(ClientPassword);
                    BlockedClientEmails.Close();
                    BlockedClientNames.Close();
                    BlockedClientPasswords.Close();
                    MessageBox.Show("Your account is blocked.\n Please contact to Client for more details!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //verify
        private void VerifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                verifyButtonClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
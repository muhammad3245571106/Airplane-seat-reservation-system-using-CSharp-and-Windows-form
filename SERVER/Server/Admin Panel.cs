using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Server
{
    public partial class Admin_Panel : Form
    {
        #region Variables
        bool IsAdminCollapsed = true;
        bool IsAdminBlockCollapsed = true;
        bool IsAdminPendingCollapsed = true;
        bool IsVerifyAdminCollapsed = true;
        bool IsClientCollapsed = true;
        #endregion

        #region Constructor
        public Admin_Panel()
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

        #region AdminPanelControl
        //Close Admin panel
        private void Close_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Minimize admin panel
        private void Minimize_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Dropdown
        //Admin dropdown
        private void AdminButton_Click(object sender, EventArgs e)
        {
            try
            {
                int points = 10;
                if (IsAdminCollapsed)
                {
                    while (AdminDropdown.Size != AdminDropdown.MaximumSize)
                    {
                        AdminDropdown.Height += points;
                        IsAdminCollapsed = false;
                    }
                }
                else
                {
                    while (AdminDropdown.Size != AdminDropdown.MinimumSize)
                    {
                        AdminDropdown.Height -= points;
                        IsAdminCollapsed = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Admin block dropdown
        private void AdminBlockButton_Click(object sender, EventArgs e)
        {
            try
            {
                int points = 10;
                if (IsAdminBlockCollapsed)
                {
                    AdminDropdown.MaximumSize += new Size(0, 60);
                    while (AdminBlockDropdown.Size != AdminBlockDropdown.MaximumSize)
                    {
                        AdminUnblockButton.Location = new Point(AdminUnblockButton.Location.X, AdminUnblockButton.Location.Y + points);
                        VerifyDropdown.Location = new Point(VerifyDropdown.Location.X, VerifyDropdown.Location.Y + points);
                        AddToPendingDropdown.Location = new Point(AddToPendingDropdown.Location.X, AddToPendingDropdown.Location.Y + points);
                        AdminDropdown.Height += points;
                        AdminBlockDropdown.Height += points;
                        IsAdminBlockCollapsed = false;
                    }
                }
                else
                {
                    while (AdminBlockDropdown.Size != AdminBlockDropdown.MinimumSize)
                    {
                        AdminUnblockButton.Location = new Point(AdminUnblockButton.Location.X, AdminUnblockButton.Location.Y - points);
                        VerifyDropdown.Location = new Point(VerifyDropdown.Location.X, VerifyDropdown.Location.Y - points);
                        AddToPendingDropdown.Location = new Point(AddToPendingDropdown.Location.X, AddToPendingDropdown.Location.Y - points);
                        AdminDropdown.Height -= points;
                        AdminBlockDropdown.Height -= points;
                        IsAdminBlockCollapsed = true;
                    }
                    AdminDropdown.MaximumSize -= new Size(0, 60);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Admin verify dropdown
        private void VerifyAdminButton_Click(object sender, EventArgs e)
        {
            try
            {
                int points = 10;
                if (IsVerifyAdminCollapsed)
                {
                    AdminDropdown.MaximumSize += new Size(0, 60);
                    while (VerifyDropdown.Size != VerifyDropdown.MaximumSize)
                    {
                        AddToPendingDropdown.Location = new Point(AddToPendingDropdown.Location.X, AddToPendingDropdown.Location.Y + points);
                        AdminDropdown.Height += points;
                        VerifyDropdown.Height += points;
                        IsVerifyAdminCollapsed = false;
                    }
                }
                else
                {
                    while (VerifyDropdown.Size != VerifyDropdown.MinimumSize)
                    {
                        AddToPendingDropdown.Location = new Point(AddToPendingDropdown.Location.X, AddToPendingDropdown.Location.Y - points);
                        AdminDropdown.Height -= points;
                        VerifyDropdown.Height -= points;
                        IsVerifyAdminCollapsed = true;
                    }
                    AdminDropdown.MaximumSize -= new Size(0, 60);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Admin pending dropdown
        private void AddAdminToPendingButton_Click(object sender, EventArgs e)
        {
            try
            {
                int points = 10;
                if (IsAdminPendingCollapsed)
                {
                    AdminDropdown.MaximumSize += new Size(0, 60);
                    while (AddToPendingDropdown.Size != AddToPendingDropdown.MaximumSize)
                    {
                        AdminDropdown.Height += points;
                        AddToPendingDropdown.Height += points;
                        IsAdminPendingCollapsed = false;
                    }
                }
                else
                {
                    while (AddToPendingDropdown.Size != AddToPendingDropdown.MinimumSize)
                    {
                        AdminDropdown.Height -= points;
                        AddToPendingDropdown.Height -= points;
                        IsAdminPendingCollapsed = true;
                    }
                    AdminDropdown.MaximumSize -= new Size(0, 60);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Client dropdown
        private void ClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                int points = 10;
                if (IsClientCollapsed)
                {
                    while (ClientDropdown.Size != ClientDropdown.MaximumSize)
                    {
                        ClientDropdown.Height += points;
                        IsClientCollapsed = false;
                    }
                }
                else
                {
                    while (ClientDropdown.Size != ClientDropdown.MinimumSize)
                    {
                        ClientDropdown.Height -= points;
                        IsClientCollapsed = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region AdminFileHandling
        //Admin Operations File handling
        //Block admin
        private bool BlockAdmin(string email, string name, string password)
        {
            try
            {
                StreamWriter BlockedAdminEmails = new StreamWriter("../../Data/AdminData/BlockedAdminEmails.txt", append: true);
                StreamWriter BlockedAdminNames = new StreamWriter("../../Data/AdminData/BlockedAdminNames.txt", append: true);
                StreamWriter BlockedAdminPasswords = new StreamWriter("../../Data/AdminData/BlockedAdminPasswords.txt", append: true);
                BlockedAdminEmails.WriteLine(email);
                BlockedAdminNames.WriteLine(name);
                BlockedAdminPasswords.WriteLine(password);
                BlockedAdminEmails.Close();
                BlockedAdminNames.Close();
                BlockedAdminPasswords.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //unblock admin
        private bool UnBlockAdmin(string email, ref string name, ref string password)
        {
            try
            {
                StreamReader BlockedAdminEmails = new StreamReader("../../Data/AdminData/BlockedAdminEmails.txt");
                StreamReader BlockedAdminNames = new StreamReader("../../Data/AdminData/BlockedAdminNames.txt");
                StreamReader BlockedAdminPasswords = new StreamReader("../../Data/AdminData/BlockedAdminPasswords.txt");
                StreamWriter newBlockedEmails = new StreamWriter("../../Data/AdminData/BlockedAdminEmails2.txt");
                StreamWriter newBlockedNames = new StreamWriter("../../Data/AdminData/BlockedAdminNames2.txt");
                StreamWriter newBlockedPasswords = new StreamWriter("../../Data/AdminData/BlockedAdminPasswords2.txt");
                string emails;
                string names;
                string passwords;
                bool isUnblocked = false;
                while (!BlockedAdminEmails.EndOfStream)
                {
                    emails = BlockedAdminEmails.ReadLine();
                    names = BlockedAdminNames.ReadLine();
                    passwords = BlockedAdminPasswords.ReadLine();
                    if (emails == email)
                    {
                        name = names;
                        password = passwords;
                        isUnblocked = true;
                    }
                    else
                    {
                        newBlockedEmails.WriteLine(emails);
                        newBlockedNames.WriteLine(names);
                        newBlockedPasswords.WriteLine(passwords);
                    }
                }
                BlockedAdminEmails.Close();
                BlockedAdminNames.Close();
                BlockedAdminPasswords.Close();
                newBlockedEmails.Close();
                newBlockedNames.Close();
                newBlockedPasswords.Close();
                File.Delete("../../Data/AdminData/BlockedAdminEmails.txt");
                File.Delete("../../Data/AdminData/BlockedAdminNames.txt");
                File.Delete("../../Data/AdminData/BlockedAdminPasswords.txt");
                File.Move("../../Data/AdminData/BlockedAdminEmails2.txt", "../../Data/AdminData/BlockedAdminEmails.txt");
                File.Move("../../Data/AdminData/BlockedAdminNames2.txt", "../../Data/AdminData/BlockedAdminNames.txt");
                File.Move("../../Data/AdminData/BlockedAdminPasswords2.txt", "../../Data/AdminData/BlockedAdminPasswords.txt");
                return isUnblocked;
            }
            catch
            {
                return false;
            }
        }
        //unblock admin
        private bool UnBlockAdmin(string email)
        {
            try
            {
                StreamReader BlockedAdminEmails = new StreamReader("../../Data/AdminData/BlockedAdminEmails.txt");
                StreamReader BlockedAdminNames = new StreamReader("../../Data/AdminData/BlockedAdminNames.txt");
                StreamReader BlockedAdminPasswords = new StreamReader("../../Data/AdminData/BlockedAdminPasswords.txt");
                StreamWriter newBlockedEmails = new StreamWriter("../../Data/AdminData/BlockedAdminEmails2.txt");
                StreamWriter newBlockedNames = new StreamWriter("../../Data/AdminData/BlockedAdminNames2.txt");
                StreamWriter newBlockedPasswords = new StreamWriter("../../Data/AdminData/BlockedAdminPasswords2.txt");
                string emails;
                string names;
                string passwords;
                bool isUnblocked = false;
                while (!BlockedAdminEmails.EndOfStream)
                {
                    emails = BlockedAdminEmails.ReadLine();
                    names = BlockedAdminNames.ReadLine();
                    passwords = BlockedAdminPasswords.ReadLine();
                    if (emails == email)
                    {
                        isUnblocked = true;
                    }
                    else
                    {
                        newBlockedEmails.WriteLine(emails);
                        newBlockedNames.WriteLine(names);
                        newBlockedPasswords.WriteLine(passwords);
                    }
                }
                BlockedAdminEmails.Close();
                BlockedAdminNames.Close();
                BlockedAdminPasswords.Close();
                newBlockedEmails.Close();
                newBlockedNames.Close();
                newBlockedPasswords.Close();
                File.Delete("../../Data/AdminData/BlockedAdminEmails.txt");
                File.Delete("../../Data/AdminData/BlockedAdminNames.txt");
                File.Delete("../../Data/AdminData/BlockedAdminPasswords.txt");
                File.Move("../../Data/AdminData/BlockedAdminEmails2.txt", "../../Data/AdminData/BlockedAdminEmails.txt");
                File.Move("../../Data/AdminData/BlockedAdminNames2.txt", "../../Data/AdminData/BlockedAdminNames.txt");
                File.Move("../../Data/AdminData/BlockedAdminPasswords2.txt", "../../Data/AdminData/BlockedAdminPasswords.txt");
                return isUnblocked;
            }
            catch
            {
                return false;
            }
        }
        //Remove admin from pending
        private bool RemoveAdminFromPending(string email, ref string name, ref string password)
        {
            try
            {
                StreamReader PendingAdminEmails = new StreamReader("../../Data/AdminData/PendingAdminEmails.txt");
                StreamReader PendingAdminNames = new StreamReader("../../Data/AdminData/PendingAdminNames.txt");
                StreamReader PendingAdminPasswords = new StreamReader("../../Data/AdminData/PendingAdminPasswords.txt");
                StreamWriter newPendingEmails = new StreamWriter("../../Data/AdminData/PendingAdminEmails2.txt");
                StreamWriter newPendingNames = new StreamWriter("../../Data/AdminData/PendingAdminNames2.txt");
                StreamWriter newPendingPasswords = new StreamWriter("../../Data/AdminData/PendingAdminPasswords2.txt");
                string emails;
                string names;
                string passwords;
                bool isRemoved = false;
                while (!PendingAdminEmails.EndOfStream)
                {
                    emails = PendingAdminEmails.ReadLine();
                    names = PendingAdminNames.ReadLine();
                    passwords = PendingAdminPasswords.ReadLine();
                    if (emails == email)
                    {
                        name = names;
                        password = passwords;
                        isRemoved = true;
                    }
                    else
                    {
                        newPendingEmails.WriteLine(emails);
                        newPendingNames.WriteLine(names);
                        newPendingPasswords.WriteLine(passwords);
                    }
                }
                PendingAdminEmails.Close();
                PendingAdminNames.Close();
                PendingAdminPasswords.Close();
                newPendingEmails.Close();
                newPendingNames.Close();
                newPendingPasswords.Close();
                File.Delete("../../Data/AdminData/PendingAdminEmails.txt");
                File.Delete("../../Data/AdminData/PendingAdminNames.txt");
                File.Delete("../../Data/AdminData/PendingAdminPasswords.txt");
                File.Move("../../Data/AdminData/PendingAdminEmails2.txt", "../../Data/AdminData/PendingAdminEmails.txt");
                File.Move("../../Data/AdminData/PendingAdminNames2.txt", "../../Data/AdminData/PendingAdminNames.txt");
                File.Move("../../Data/AdminData/PendingAdminPasswords2.txt", "../../Data/AdminData/PendingAdminPasswords.txt");
                return isRemoved;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        //Add admin to pending
        private bool AddAdminToPending(string email, string name, string password)
        {
            try
            {
                StreamWriter PendingAdminEmails = new StreamWriter("../../Data/AdminData/PendingAdminEmails.txt", append: true);
                StreamWriter PendingAdminNames = new StreamWriter("../../Data/AdminData/PendingAdminNames.txt", append: true);
                StreamWriter PendingAdminPasswords = new StreamWriter("../../Data/AdminData/PendingAdminPasswords.txt", append: true);
                PendingAdminEmails.WriteLine(email);
                PendingAdminNames.WriteLine(name);
                PendingAdminPasswords.WriteLine(password);
                PendingAdminEmails.Close();
                PendingAdminNames.Close();
                PendingAdminPasswords.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Add admin to verified admin
        private bool AddAdmin(string email, string name, string password)
        {
            try
            {
                StreamWriter AdminEmails = new StreamWriter("../../Data/AdminData/AdminEmails.txt", append: true);
                StreamWriter AdminNames = new StreamWriter("../../Data/AdminData/AdminNames.txt", append: true);
                StreamWriter AdminPasswords = new StreamWriter("../../Data/AdminData/AdminPasswords.txt", append: true);
                AdminEmails.WriteLine(email);
                AdminNames.WriteLine(name);
                AdminPasswords.WriteLine(password);
                AdminEmails.Close();
                AdminNames.Close();
                AdminPasswords.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Remove admin to verified admin
        private bool RemoveAdmin(string email, ref string name, ref string password)
        {
            try
            {
                StreamReader AdminEmails = new StreamReader("../../Data/AdminData/AdminEmails.txt");
                StreamReader AdminNames = new StreamReader("../../Data/AdminData/AdminNames.txt");
                StreamReader AdminPasswords = new StreamReader("../../Data/AdminData/AdminPasswords.txt");
                StreamWriter newEmails = new StreamWriter("../../Data/AdminData/AdminEmails2.txt");
                StreamWriter newNames = new StreamWriter("../../Data/AdminData/AdminNames2.txt");
                StreamWriter newPasswords = new StreamWriter("../../Data/AdminData/AdminPasswords2.txt");
                string emails;
                string names;
                string passwords;
                bool isRemoved = false;
                while (!AdminEmails.EndOfStream)
                {
                    emails = AdminEmails.ReadLine();
                    names = AdminNames.ReadLine();
                    passwords = AdminPasswords.ReadLine();
                    if (emails == email)
                    {
                        name = names;
                        password = passwords;
                        isRemoved = true;
                    }
                    else
                    {
                        newEmails.WriteLine(emails);
                        newNames.WriteLine(names);
                        newPasswords.WriteLine(passwords);
                    }
                }
                AdminEmails.Close();
                AdminNames.Close();
                AdminPasswords.Close();
                newEmails.Close();
                newNames.Close();
                newPasswords.Close();
                File.Delete("../../Data/AdminData/AdminEmails.txt");
                File.Delete("../../Data/AdminData/AdminNames.txt");
                File.Delete("../../Data/AdminData/AdminPasswords.txt");
                File.Move("../../Data/AdminData/AdminEmails2.txt", "../../Data/AdminData/AdminEmails.txt");
                File.Move("../../Data/AdminData/AdminNames2.txt", "../../Data/AdminData/AdminNames.txt");
                File.Move("../../Data/AdminData/AdminPasswords2.txt", "../../Data/AdminData/AdminPasswords.txt");
                return isRemoved;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region ClientFileHandling
        //Client Operations File handling
        //Block Client
        private bool BlockClient(string email, string name, string password)
        {
            try
            {
                StreamWriter BlockedClientEmails = new StreamWriter("../../Data/ClientData/BlockedClientEmails.txt", append: true);
                StreamWriter BlockedClientNames = new StreamWriter("../../Data/ClientData/BlockedClientNames.txt", append: true);
                StreamWriter BlockedClientPasswords = new StreamWriter("../../Data/ClientData/BlockedClientPasswords.txt", append: true);
                BlockedClientEmails.WriteLine(email);
                BlockedClientNames.WriteLine(name);
                BlockedClientPasswords.WriteLine(password);
                BlockedClientEmails.Close();
                BlockedClientNames.Close();
                BlockedClientPasswords.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //unblock Client
        private bool UnBlockClient(string email, ref string name, ref string password)
        {
            try
            {
                StreamReader BlockedClientEmails = new StreamReader("../../Data/ClientData/BlockedClientEmails.txt");
                StreamReader BlockedClientNames = new StreamReader("../../Data/ClientData/BlockedClientNames.txt");
                StreamReader BlockedClientPasswords = new StreamReader("../../Data/ClientData/BlockedClientPasswords.txt");
                StreamWriter newBlockedEmails = new StreamWriter("../../Data/ClientData/BlockedClientEmails2.txt");
                StreamWriter newBlockedNames = new StreamWriter("../../Data/ClientData/BlockedClientNames2.txt");
                StreamWriter newBlockedPasswords = new StreamWriter("../../Data/ClientData/BlockedClientPasswords2.txt");
                string emails;
                string names;
                string passwords;
                bool isUnblocked = false;
                while (!BlockedClientEmails.EndOfStream)
                {
                    emails = BlockedClientEmails.ReadLine();
                    names = BlockedClientNames.ReadLine();
                    passwords = BlockedClientPasswords.ReadLine();
                    if (emails == email)
                    {
                        name = names;
                        password = passwords;
                        isUnblocked = true;
                    }
                    else
                    {
                        newBlockedEmails.WriteLine(emails);
                        newBlockedNames.WriteLine(names);
                        newBlockedPasswords.WriteLine(passwords);
                    }
                }
                BlockedClientEmails.Close();
                BlockedClientNames.Close();
                BlockedClientPasswords.Close();
                newBlockedEmails.Close();
                newBlockedNames.Close();
                newBlockedPasswords.Close();
                File.Delete("../../Data/ClientData/BlockedClientEmails.txt");
                File.Delete("../../Data/ClientData/BlockedClientNames.txt");
                File.Delete("../../Data/ClientData/BlockedClientPasswords.txt");
                File.Move("../../Data/ClientData/BlockedClientEmails2.txt", "../../Data/ClientData/BlockedClientEmails.txt");
                File.Move("../../Data/ClientData/BlockedClientNames2.txt", "../../Data/ClientData/BlockedClientNames.txt");
                File.Move("../../Data/ClientData/BlockedClientPasswords2.txt", "../../Data/ClientData/BlockedClientPasswords.txt");
                return isUnblocked;
            }
            catch
            {
                return false;
            }
        }
        //Add Client to verified Client
        private bool AddClient(string email, string name, string password)
        {
            try
            {
                StreamWriter ClientEmails = new StreamWriter("../../Data/ClientData/ClientEmails.txt", append: true);
                StreamWriter ClientNames = new StreamWriter("../../Data/ClientData/ClientNames.txt", append: true);
                StreamWriter ClientPasswords = new StreamWriter("../../Data/ClientData/ClientPasswords.txt", append: true);
                ClientEmails.WriteLine(email);
                ClientNames.WriteLine(name);
                ClientPasswords.WriteLine(password);
                ClientEmails.Close();
                ClientNames.Close();
                ClientPasswords.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Remove Client to verified Client
        private bool RemoveClient(string email, ref string name, ref string password)
        {
            try
            {
                StreamReader ClientEmails = new StreamReader("../../Data/ClientData/ClientEmails.txt");
                StreamReader ClientNames = new StreamReader("../../Data/ClientData/ClientNames.txt");
                StreamReader ClientPasswords = new StreamReader("../../Data/ClientData/ClientPasswords.txt");
                StreamWriter newEmails = new StreamWriter("../../Data/ClientData/ClientEmails2.txt");
                StreamWriter newNames = new StreamWriter("../../Data/ClientData/ClientNames2.txt");
                StreamWriter newPasswords = new StreamWriter("../../Data/ClientData/ClientPasswords2.txt");
                string emails;
                string names;
                string passwords;
                bool isRemoved = false;
                while (!ClientEmails.EndOfStream)
                {
                    emails = ClientEmails.ReadLine();
                    names = ClientNames.ReadLine();
                    passwords = ClientPasswords.ReadLine();
                    if (emails == email)
                    {
                        name = names;
                        password = passwords;
                        isRemoved = true;
                    }
                    else
                    {
                        newEmails.WriteLine(emails);
                        newNames.WriteLine(names);
                        newPasswords.WriteLine(passwords);
                    }
                }
                ClientEmails.Close();
                ClientNames.Close();
                ClientPasswords.Close();
                newEmails.Close();
                newNames.Close();
                newPasswords.Close();
                File.Delete("../../Data/ClientData/ClientEmails.txt");
                File.Delete("../../Data/ClientData/ClientNames.txt");
                File.Delete("../../Data/ClientData/ClientPasswords.txt");
                File.Move("../../Data/ClientData/ClientEmails2.txt", "../../Data/ClientData/ClientEmails.txt");
                File.Move("../../Data/ClientData/ClientNames2.txt", "../../Data/ClientData/ClientNames.txt");
                File.Move("../../Data/ClientData/ClientPasswords2.txt", "../../Data/ClientData/ClientPasswords.txt");
                return isRemoved;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region AdminPowers
        #region AdminOperations
        //Block pending admin portion
        private void AdminBlockPendingButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.Items.Clear();
                ListBox.Visible = true;
                BlockPendingAdminFormButton.Visible = true;
                BlockVerifiedAdminFormButton.Visible = false;
                UnblockAdminFormButton.Visible = false;
                VerifyPendingAdminFormButton.Visible = false;
                VerifyBlockedAdminFormButton.Visible = false;
                PendingBlockedAdminFormButton.Visible = false;
                PendingVerifiedAdminFormButton.Visible = false;
                BlockClientFormButton.Visible = false;
                UnblockClientFormButton.Visible = false;
                StreamReader PendingAdminEmails = new StreamReader("../../Data/AdminData/PendingAdminEmails.txt");
                string emails;
                while (!PendingAdminEmails.EndOfStream)
                {
                    emails = PendingAdminEmails.ReadLine();
                    ListBox.Items.Add(emails);
                }
                PendingAdminEmails.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Block pending admin button
        private void BlockPendingAdminFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select admin to block!");
                }
                else
                {
                    string email = ListBox.SelectedItem.ToString();
                    string name = "";
                    string password = "";
                    if (RemoveAdminFromPending(email, ref name, ref password))
                    {
                        ListBox.Items.Remove(ListBox.SelectedItem.ToString());
                    }
                    if (BlockAdmin(email, name, password))
                    {
                        MessageBox.Show("Admin blocked successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Admin not blocked due to system error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Block verified admin portion
        private void AdminBlcokVerifiedButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.Items.Clear();
                ListBox.Visible = true;
                BlockPendingAdminFormButton.Visible = false;
                BlockVerifiedAdminFormButton.Visible = true;
                UnblockAdminFormButton.Visible = false;
                VerifyPendingAdminFormButton.Visible = false;
                VerifyBlockedAdminFormButton.Visible = false;
                PendingBlockedAdminFormButton.Visible = false;
                PendingVerifiedAdminFormButton.Visible = false;
                BlockClientFormButton.Visible = false;
                UnblockClientFormButton.Visible = false;
                StreamReader AdminEmails = new StreamReader("../../Data/AdminData/AdminEmails.txt");
                string emails;
                while (!AdminEmails.EndOfStream)
                {
                    emails = AdminEmails.ReadLine();
                    ListBox.Items.Add(emails);
                }
                AdminEmails.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Block verified admin button
        private void BlockVerifiedAdminFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select admin to block!");
                }
                else
                {
                    string email = ListBox.SelectedItem.ToString();
                    string name = "";
                    string password = "";
                    if (RemoveAdmin(email, ref name, ref password))
                    {
                        ListBox.Items.Remove(ListBox.SelectedItem.ToString());
                    }
                    if (BlockAdmin(email, name, password))
                    {
                        MessageBox.Show("Admin blocked successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Admin not blocked due to system error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Unblock admin portion
        private void AdminUnblockButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.Items.Clear();
                ListBox.Visible = true;
                BlockPendingAdminFormButton.Visible = false;
                BlockVerifiedAdminFormButton.Visible = false;
                UnblockAdminFormButton.Visible = true;
                VerifyPendingAdminFormButton.Visible = false;
                VerifyBlockedAdminFormButton.Visible = false;
                PendingBlockedAdminFormButton.Visible = false;
                PendingVerifiedAdminFormButton.Visible = false;
                BlockClientFormButton.Visible = false;
                UnblockClientFormButton.Visible = false;
                StreamReader BlockedAdminEmails = new StreamReader("../../Data/AdminData/BlockedAdminEmails.txt");
                string emails;
                while (!BlockedAdminEmails.EndOfStream)
                {
                    emails = BlockedAdminEmails.ReadLine();
                    ListBox.Items.Add(emails);
                }
                BlockedAdminEmails.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Unblock admin button
        private void UnblockAdminFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select admin to unblock!");
                }
                else
                {
                    if (UnBlockAdmin(ListBox.SelectedItem.ToString()))
                    {
                        ListBox.Items.Remove(ListBox.SelectedItem.ToString());
                        MessageBox.Show("Admin unblocked successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Admin not unblocked due to system error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Verify pending admin portion
        private void VerifyPendingAdminButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.Items.Clear();
                ListBox.Visible = true;
                BlockPendingAdminFormButton.Visible = false;
                BlockVerifiedAdminFormButton.Visible = false;
                UnblockAdminFormButton.Visible = false;
                VerifyPendingAdminFormButton.Visible = true;
                VerifyBlockedAdminFormButton.Visible = false;
                PendingBlockedAdminFormButton.Visible = false;
                PendingVerifiedAdminFormButton.Visible = false;
                BlockClientFormButton.Visible = false;
                UnblockClientFormButton.Visible = false;
                StreamReader PendingAdminEmails = new StreamReader("../../Data/AdminData/PendingAdminEmails.txt");
                string emails;
                while (!PendingAdminEmails.EndOfStream)
                {
                    emails = PendingAdminEmails.ReadLine();
                    ListBox.Items.Add(emails);
                }
                PendingAdminEmails.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Verify pending admin button
        private void VerifyPendingAdminFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select admin to verify!");
                }
                else
                {
                    string email = ListBox.SelectedItem.ToString();
                    string name = "";
                    string password = "";
                    if (RemoveAdminFromPending(email, ref name, ref password))
                    {
                        ListBox.Items.Remove(ListBox.SelectedItem.ToString());
                    }
                    if (AddAdmin(email, name, password))
                    {
                        MessageBox.Show("Admin verified successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Admin not verified due to system error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Verify blocked admin portion
        private void VerifyBlockedAdminButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.Items.Clear();
                ListBox.Visible = true;
                BlockPendingAdminFormButton.Visible = false;
                BlockVerifiedAdminFormButton.Visible = false;
                UnblockAdminFormButton.Visible = false;
                VerifyPendingAdminFormButton.Visible = false;
                VerifyBlockedAdminFormButton.Visible = true;
                PendingBlockedAdminFormButton.Visible = false;
                PendingVerifiedAdminFormButton.Visible = false;
                BlockClientFormButton.Visible = false;
                UnblockClientFormButton.Visible = false;
                StreamReader BlockedAdminEmails = new StreamReader("../../Data/AdminData/BlockedAdminEmails.txt");
                string emails;
                while (!BlockedAdminEmails.EndOfStream)
                {
                    emails = BlockedAdminEmails.ReadLine();
                    ListBox.Items.Add(emails);
                }
                BlockedAdminEmails.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Verify blocked admin button
        private void VerifyBlockedAdminFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select admin to verify!");
                }
                else
                {
                    string email = ListBox.SelectedItem.ToString();
                    string name = "";
                    string password = "";
                    if (UnBlockAdmin(email, ref name, ref password))
                    {
                        ListBox.Items.Remove(ListBox.SelectedItem.ToString());
                    }
                    if (AddAdmin(email, name, password))
                    {
                        MessageBox.Show("Admin verified successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Admin not verified due to system error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Add blocked admin to pending portion
        private void AddBlockedAdminToPendingButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.Items.Clear();
                ListBox.Visible = true;
                BlockPendingAdminFormButton.Visible = false;
                BlockVerifiedAdminFormButton.Visible = false;
                UnblockAdminFormButton.Visible = false;
                VerifyPendingAdminFormButton.Visible = false;
                VerifyBlockedAdminFormButton.Visible = false;
                PendingBlockedAdminFormButton.Visible = true;
                PendingVerifiedAdminFormButton.Visible = false;
                BlockClientFormButton.Visible = false;
                UnblockClientFormButton.Visible = false;
                StreamReader BlockedAdminEmails = new StreamReader("../../Data/AdminData/BlockedAdminEmails.txt");
                string emails;
                while (!BlockedAdminEmails.EndOfStream)
                {
                    emails = BlockedAdminEmails.ReadLine();
                    ListBox.Items.Add(emails);
                }
                BlockedAdminEmails.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Add blocked admin to pending button
        private void PendingBlockedAdminFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select admin to add to pending!");
                }
                else
                {
                    string email = ListBox.SelectedItem.ToString();
                    string name = "";
                    string password = "";
                    if (UnBlockAdmin(email, ref name, ref password))
                    {
                        ListBox.Items.Remove(ListBox.SelectedItem.ToString());
                    }
                    if (AddAdminToPending(email, name, password))
                    {
                        MessageBox.Show("Admin added to pending successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Admin not added to pending due to system error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Add verified admin to pending portion
        private void AddVerifiedAdminToPendingButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.Items.Clear();
                ListBox.Visible = true;
                BlockPendingAdminFormButton.Visible = false;
                BlockVerifiedAdminFormButton.Visible = false;
                UnblockAdminFormButton.Visible = false;
                VerifyPendingAdminFormButton.Visible = false;
                VerifyBlockedAdminFormButton.Visible = false;
                PendingBlockedAdminFormButton.Visible = false;
                PendingVerifiedAdminFormButton.Visible = true;
                BlockClientFormButton.Visible = false;
                UnblockClientFormButton.Visible = false;
                StreamReader AdminEmails = new StreamReader("../../Data/AdminData/AdminEmails.txt");
                string emails;
                while (!AdminEmails.EndOfStream)
                {
                    emails = AdminEmails.ReadLine();
                    ListBox.Items.Add(emails);
                }
                AdminEmails.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Add verified admin to pending button
        private void PendingVerifiedAdminFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select admin to add to pending!");
                }
                else
                {
                    string email = ListBox.SelectedItem.ToString();
                    string name = "";
                    string password = "";
                    if (RemoveAdmin(email, ref name, ref password))
                    {
                        ListBox.Items.Remove(ListBox.SelectedItem.ToString());
                    }
                    if (AddAdminToPending(email, name, password))
                    {
                        MessageBox.Show("Admin added to pending successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Admin not added to pending due to system error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ClientOperations
        //Block client portion
        private void ClientBlockButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.Items.Clear();
                ListBox.Visible = true;
                BlockPendingAdminFormButton.Visible = false;
                BlockVerifiedAdminFormButton.Visible = false;
                UnblockAdminFormButton.Visible = false;
                VerifyPendingAdminFormButton.Visible = false;
                VerifyBlockedAdminFormButton.Visible = false;
                PendingBlockedAdminFormButton.Visible = false;
                PendingVerifiedAdminFormButton.Visible = false;
                BlockClientFormButton.Visible = true;
                UnblockClientFormButton.Visible = false;
                StreamReader ClientEmails = new StreamReader("../../Data/ClientData/ClientEmails.txt");
                StreamReader ClientPasswords = new StreamReader("../../Data/ClientData/ClientPasswords.txt");
                string emails;
                while (!ClientEmails.EndOfStream)
                {
                    emails = ClientEmails.ReadLine() + "\t" + ClientPasswords.ReadLine();
                    ListBox.Items.Add(emails);
                }
                ClientEmails.Close();
                ClientPasswords.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Block client button
        private void BlockClientFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select client to block!");
                }
                else
                {
                    string email = ListBox.SelectedItem.ToString();
                    string name = "";
                    string password = "";
                    if (RemoveClient(email, ref name, ref password))
                    {
                        ListBox.Items.Remove(ListBox.SelectedItem.ToString());
                    }
                    if (BlockClient(email, name, password))
                    {
                        MessageBox.Show("Client blocked successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Client not blocked due to system error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Unblock client portion
        private void ClientUnblockButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.Items.Clear();
                ListBox.Visible = true;
                BlockPendingAdminFormButton.Visible = false;
                BlockVerifiedAdminFormButton.Visible = false;
                UnblockAdminFormButton.Visible = false;
                VerifyPendingAdminFormButton.Visible = false;
                VerifyBlockedAdminFormButton.Visible = false;
                PendingBlockedAdminFormButton.Visible = false;
                PendingVerifiedAdminFormButton.Visible = false;
                BlockClientFormButton.Visible = false;
                UnblockClientFormButton.Visible = true;
                StreamReader ClientEmails = new StreamReader("../../Data/ClientData/BlockedClientEmails.txt");
                string emails;
                while (!ClientEmails.EndOfStream)
                {
                    emails = ClientEmails.ReadLine();
                    ListBox.Items.Add(emails);
                }
                ClientEmails.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //unblock client button
        private void UnblockClientFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select client to unblock!");
                }
                else
                {
                    string email = ListBox.SelectedItem.ToString();
                    string name = "";
                    string password = "";
                    if (UnBlockClient(email, ref name, ref password))
                    {
                        ListBox.Items.Remove(ListBox.SelectedItem.ToString());
                    }
                    if (AddClient(email, name, password))
                    {
                        MessageBox.Show("Client unblocked successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Client not unblocked due to system error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #endregion

        #region SignOut
        private void SignOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Thank you for using our service!\nNice to meet you!", "Thanks");
                this.Hide();
                var SignOut = new SignInUp();
                SignOut.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}
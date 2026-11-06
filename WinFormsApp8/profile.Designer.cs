namespace WinFormsApp8
{
    partial class profile
    {
        private System.ComponentModel.IContainer components = null;

        private Panel sidebarPanel;
        private Panel mainPanel;
        private Panel selectedProfilePanel;
        private Panel sidebarSeparator;
        private Panel summaryCard;
        private Panel accountCard;
        private Panel passwordCard;
        private Panel summarySeparator;
        private Label appTitleLabel;
        private Label dashboardIndicator;
        private Label dashboardLabel;
        private Label projectsIndicator;
        private Label projectsNavLabel;
        private Label kanbanIndicator;
        private Label kanbanLabel;
        private Label reportsIndicator;
        private Label reportsLabel;
        private Label notificationsIndicator;
        private Label notificationsLabel;
        private Label notificationBadge;
        private Label profileIndicator;
        private Label profileNavLabel;
        private Label connectionIndicator;
        private Label connectionLabel;
        private Label sidebarUserLabel;
        private Label sidebarOwnerLabel;
        private Label pageTitleLabel;
        private Label pageSubtitleLabel;
        private Label avatarLabel;
        private Label profileNameLabel;
        private Label profileEmailLabel;
        private Label ownerBadgeLabel;
        private Label projectsStatLabel;
        private Label projectsStatValueLabel;
        private Label openTasksStatLabel;
        private Label openTasksStatValueLabel;
        private Label completedStatLabel;
        private Label completedStatValueLabel;
        private Label accountTitleLabel;
        private Label fullNameLabel;
        private TextBox fullNameTextBox;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Button saveChangesButton;
        private Label passwordTitleLabel;
        private Label currentPasswordLabel;
        private TextBox currentPasswordTextBox;
        private Label newPasswordLabel;
        private TextBox newPasswordTextBox;
        private Label confirmPasswordLabel;
        private TextBox confirmPasswordTextBox;
        private Label passwordMismatchIconLabel;
        private Label passwordMismatchLabel;
        private Label passwordHelpLabel;
        private Button updatePasswordButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            sidebarPanel = new Panel();
            appTitleLabel = new Label();
            dashboardIndicator = new Label();
            dashboardLabel = new Label();
            projectsIndicator = new Label();
            projectsNavLabel = new Label();
            kanbanIndicator = new Label();
            kanbanLabel = new Label();
            reportsIndicator = new Label();
            reportsLabel = new Label();
            notificationsIndicator = new Label();
            notificationsLabel = new Label();
            notificationBadge = new Label();
            selectedProfilePanel = new Panel();
            profileIndicator = new Label();
            profileNavLabel = new Label();
            sidebarSeparator = new Panel();
            connectionIndicator = new Label();
            connectionLabel = new Label();
            sidebarUserLabel = new Label();
            sidebarOwnerLabel = new Label();
            mainPanel = new Panel();
            pageTitleLabel = new Label();
            pageSubtitleLabel = new Label();
            summaryCard = new Panel();
            avatarLabel = new Label();
            profileNameLabel = new Label();
            profileEmailLabel = new Label();
            ownerBadgeLabel = new Label();
            summarySeparator = new Panel();
            projectsStatLabel = new Label();
            projectsStatValueLabel = new Label();
            openTasksStatLabel = new Label();
            openTasksStatValueLabel = new Label();
            completedStatLabel = new Label();
            completedStatValueLabel = new Label();
            accountCard = new Panel();
            accountTitleLabel = new Label();
            fullNameLabel = new Label();
            fullNameTextBox = new TextBox();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            saveChangesButton = new Button();
            passwordCard = new Panel();
            passwordTitleLabel = new Label();
            currentPasswordLabel = new Label();
            currentPasswordTextBox = new TextBox();
            newPasswordLabel = new Label();
            newPasswordTextBox = new TextBox();
            confirmPasswordLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            passwordMismatchIconLabel = new Label();
            passwordMismatchLabel = new Label();
            passwordHelpLabel = new Label();
            updatePasswordButton = new Button();
            sidebarPanel.SuspendLayout();
            selectedProfilePanel.SuspendLayout();
            mainPanel.SuspendLayout();
            summaryCard.SuspendLayout();
            accountCard.SuspendLayout();
            passwordCard.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(27, 37, 64);
            sidebarPanel.Controls.Add(appTitleLabel);
            sidebarPanel.Controls.Add(dashboardIndicator);
            sidebarPanel.Controls.Add(dashboardLabel);
            sidebarPanel.Controls.Add(projectsIndicator);
            sidebarPanel.Controls.Add(projectsNavLabel);
            sidebarPanel.Controls.Add(kanbanIndicator);
            sidebarPanel.Controls.Add(kanbanLabel);
            sidebarPanel.Controls.Add(reportsIndicator);
            sidebarPanel.Controls.Add(reportsLabel);
            sidebarPanel.Controls.Add(notificationsIndicator);
            sidebarPanel.Controls.Add(notificationsLabel);
            sidebarPanel.Controls.Add(notificationBadge);
            sidebarPanel.Controls.Add(selectedProfilePanel);
            sidebarPanel.Controls.Add(sidebarSeparator);
            sidebarPanel.Controls.Add(connectionIndicator);
            sidebarPanel.Controls.Add(connectionLabel);
            sidebarPanel.Controls.Add(sidebarUserLabel);
            sidebarPanel.Controls.Add(sidebarOwnerLabel);
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(3, 4, 3, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(265, 1093);
            sidebarPanel.TabIndex = 1;
            // 
            // appTitleLabel
            // 
            appTitleLabel.AutoSize = true;
            appTitleLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            appTitleLabel.ForeColor = Color.White;
            appTitleLabel.Location = new Point(27, 28);
            appTitleLabel.Name = "appTitleLabel";
            appTitleLabel.Size = new Size(209, 40);
            appTitleLabel.TabIndex = 0;
            appTitleLabel.Text = "Task Manager";
            // 
            // dashboardIndicator
            // 
            dashboardIndicator.AutoSize = true;
            dashboardIndicator.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dashboardIndicator.ForeColor = Color.FromArgb(132, 149, 185);
            dashboardIndicator.Location = new Point(31, 105);
            dashboardIndicator.Name = "dashboardIndicator";
            dashboardIndicator.Size = new Size(24, 28);
            dashboardIndicator.TabIndex = 1;
            dashboardIndicator.Text = "●";
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.Font = new Font("Segoe UI", 10F);
            dashboardLabel.ForeColor = Color.FromArgb(206, 214, 231);
            dashboardLabel.Location = new Point(58, 107);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(93, 23);
            dashboardLabel.TabIndex = 2;
            dashboardLabel.Text = "Dashboard";
            // 
            // projectsIndicator
            // 
            projectsIndicator.AutoSize = true;
            projectsIndicator.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            projectsIndicator.ForeColor = Color.FromArgb(132, 149, 185);
            projectsIndicator.Location = new Point(31, 167);
            projectsIndicator.Name = "projectsIndicator";
            projectsIndicator.Size = new Size(24, 28);
            projectsIndicator.TabIndex = 3;
            projectsIndicator.Text = "●";
            // 
            // projectsNavLabel
            // 
            projectsNavLabel.AutoSize = true;
            projectsNavLabel.Font = new Font("Segoe UI", 10F);
            projectsNavLabel.ForeColor = Color.FromArgb(206, 214, 231);
            projectsNavLabel.Location = new Point(58, 168);
            projectsNavLabel.Name = "projectsNavLabel";
            projectsNavLabel.Size = new Size(70, 23);
            projectsNavLabel.TabIndex = 4;
            projectsNavLabel.Text = "Projects";
            // 
            // kanbanIndicator
            // 
            kanbanIndicator.AutoSize = true;
            kanbanIndicator.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            kanbanIndicator.ForeColor = Color.FromArgb(132, 149, 185);
            kanbanIndicator.Location = new Point(31, 228);
            kanbanIndicator.Name = "kanbanIndicator";
            kanbanIndicator.Size = new Size(24, 28);
            kanbanIndicator.TabIndex = 5;
            kanbanIndicator.Text = "●";
            // 
            // kanbanLabel
            // 
            kanbanLabel.AutoSize = true;
            kanbanLabel.Font = new Font("Segoe UI", 10F);
            kanbanLabel.ForeColor = Color.FromArgb(206, 214, 231);
            kanbanLabel.Location = new Point(58, 229);
            kanbanLabel.Name = "kanbanLabel";
            kanbanLabel.Size = new Size(118, 23);
            kanbanLabel.TabIndex = 6;
            kanbanLabel.Text = "Kanban board";
            // 
            // reportsIndicator
            // 
            reportsIndicator.AutoSize = true;
            reportsIndicator.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            reportsIndicator.ForeColor = Color.FromArgb(132, 149, 185);
            reportsIndicator.Location = new Point(31, 289);
            reportsIndicator.Name = "reportsIndicator";
            reportsIndicator.Size = new Size(24, 28);
            reportsIndicator.TabIndex = 7;
            reportsIndicator.Text = "●";
            // 
            // reportsLabel
            // 
            reportsLabel.AutoSize = true;
            reportsLabel.Font = new Font("Segoe UI", 10F);
            reportsLabel.ForeColor = Color.FromArgb(206, 214, 231);
            reportsLabel.Location = new Point(58, 291);
            reportsLabel.Name = "reportsLabel";
            reportsLabel.Size = new Size(68, 23);
            reportsLabel.TabIndex = 8;
            reportsLabel.Text = "Reports";
            // 
            // notificationsIndicator
            // 
            notificationsIndicator.AutoSize = true;
            notificationsIndicator.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            notificationsIndicator.ForeColor = Color.FromArgb(132, 149, 185);
            notificationsIndicator.Location = new Point(31, 351);
            notificationsIndicator.Name = "notificationsIndicator";
            notificationsIndicator.Size = new Size(24, 28);
            notificationsIndicator.TabIndex = 9;
            notificationsIndicator.Text = "●";
            // 
            // notificationsLabel
            // 
            notificationsLabel.AutoSize = true;
            notificationsLabel.Font = new Font("Segoe UI", 10F);
            notificationsLabel.ForeColor = Color.FromArgb(206, 214, 231);
            notificationsLabel.Location = new Point(58, 352);
            notificationsLabel.Name = "notificationsLabel";
            notificationsLabel.Size = new Size(106, 23);
            notificationsLabel.TabIndex = 10;
            notificationsLabel.Text = "Notifications";
            // 
            // notificationBadge
            // 
            notificationBadge.BackColor = Color.FromArgb(217, 58, 68);
            notificationBadge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            notificationBadge.ForeColor = Color.White;
            notificationBadge.Location = new Point(207, 348);
            notificationBadge.Name = "notificationBadge";
            notificationBadge.Size = new Size(27, 28);
            notificationBadge.TabIndex = 11;
            notificationBadge.Text = "3";
            notificationBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectedProfilePanel
            // 
            selectedProfilePanel.BackColor = Color.FromArgb(47, 111, 237);
            selectedProfilePanel.Controls.Add(profileIndicator);
            selectedProfilePanel.Controls.Add(profileNavLabel);
            selectedProfilePanel.Location = new Point(14, 400);
            selectedProfilePanel.Margin = new Padding(3, 4, 3, 4);
            selectedProfilePanel.Name = "selectedProfilePanel";
            selectedProfilePanel.Size = new Size(238, 53);
            selectedProfilePanel.TabIndex = 12;
            // 
            // profileIndicator
            // 
            profileIndicator.AutoSize = true;
            profileIndicator.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            profileIndicator.ForeColor = Color.White;
            profileIndicator.Location = new Point(18, 12);
            profileIndicator.Name = "profileIndicator";
            profileIndicator.Size = new Size(24, 28);
            profileIndicator.TabIndex = 0;
            profileIndicator.Text = "●";
            // 
            // profileNavLabel
            // 
            profileNavLabel.AutoSize = true;
            profileNavLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            profileNavLabel.ForeColor = Color.White;
            profileNavLabel.Location = new Point(45, 13);
            profileNavLabel.Name = "profileNavLabel";
            profileNavLabel.Size = new Size(63, 23);
            profileNavLabel.TabIndex = 1;
            profileNavLabel.Text = "Profile";
            // 
            // sidebarSeparator
            // 
            sidebarSeparator.BackColor = Color.FromArgb(48, 61, 91);
            sidebarSeparator.Location = new Point(18, 932);
            sidebarSeparator.Margin = new Padding(3, 4, 3, 4);
            sidebarSeparator.Name = "sidebarSeparator";
            sidebarSeparator.Size = new Size(229, 1);
            sidebarSeparator.TabIndex = 13;
            // 
            // connectionIndicator
            // 
            connectionIndicator.AutoSize = true;
            connectionIndicator.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            connectionIndicator.ForeColor = Color.FromArgb(61, 214, 140);
            connectionIndicator.Location = new Point(23, 953);
            connectionIndicator.Name = "connectionIndicator";
            connectionIndicator.Size = new Size(23, 25);
            connectionIndicator.TabIndex = 14;
            connectionIndicator.Text = "●";
            // 
            // connectionLabel
            // 
            connectionLabel.AutoSize = true;
            connectionLabel.Font = new Font("Segoe UI", 9F);
            connectionLabel.ForeColor = Color.FromArgb(206, 214, 231);
            connectionLabel.Location = new Point(43, 956);
            connectionLabel.Name = "connectionLabel";
            connectionLabel.Size = new Size(183, 20);
            connectionLabel.TabIndex = 15;
            connectionLabel.Text = "Connected · 127.0.0.1:5000";
            // 
            // sidebarUserLabel
            // 
            sidebarUserLabel.AutoSize = true;
            sidebarUserLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            sidebarUserLabel.ForeColor = Color.White;
            sidebarUserLabel.Location = new Point(25, 992);
            sidebarUserLabel.Name = "sidebarUserLabel";
            sidebarUserLabel.Size = new Size(61, 23);
            sidebarUserLabel.TabIndex = 16;
            sidebarUserLabel.Text = "Yousef";
            // 
            // sidebarOwnerLabel
            // 
            sidebarOwnerLabel.AutoSize = true;
            sidebarOwnerLabel.Font = new Font("Segoe UI", 9F);
            sidebarOwnerLabel.ForeColor = Color.FromArgb(206, 214, 231);
            sidebarOwnerLabel.Location = new Point(25, 1025);
            sidebarOwnerLabel.Name = "sidebarOwnerLabel";
            sidebarOwnerLabel.Size = new Size(209, 20);
            sidebarOwnerLabel.TabIndex = 17;
            sidebarOwnerLabel.Text = "Owner · yousef@example.com";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(244, 246, 250);
            mainPanel.Controls.Add(pageTitleLabel);
            mainPanel.Controls.Add(pageSubtitleLabel);
            mainPanel.Controls.Add(summaryCard);
            mainPanel.Controls.Add(accountCard);
            mainPanel.Controls.Add(passwordCard);
            mainPanel.Location = new Point(271, 0);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1236, 1093);
            mainPanel.TabIndex = 0;
            // 
            // pageTitleLabel
            // 
            pageTitleLabel.AutoSize = true;
            pageTitleLabel.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            pageTitleLabel.ForeColor = Color.FromArgb(31, 41, 55);
            pageTitleLabel.Location = new Point(32, 36);
            pageTitleLabel.Name = "pageTitleLabel";
            pageTitleLabel.Size = new Size(128, 47);
            pageTitleLabel.TabIndex = 0;
            pageTitleLabel.Text = "Profile";
            // 
            // pageSubtitleLabel
            // 
            pageSubtitleLabel.AutoSize = true;
            pageSubtitleLabel.Font = new Font("Segoe UI", 10F);
            pageSubtitleLabel.ForeColor = Color.FromArgb(100, 112, 138);
            pageSubtitleLabel.Location = new Point(33, 88);
            pageSubtitleLabel.Name = "pageSubtitleLabel";
            pageSubtitleLabel.Size = new Size(341, 23);
            pageSubtitleLabel.TabIndex = 1;
            pageSubtitleLabel.Text = "Manage your account details and password";
            // 
            // summaryCard
            // 
            summaryCard.BackColor = Color.White;
            summaryCard.BorderStyle = BorderStyle.FixedSingle;
            summaryCard.Controls.Add(avatarLabel);
            summaryCard.Controls.Add(profileNameLabel);
            summaryCard.Controls.Add(profileEmailLabel);
            summaryCard.Controls.Add(ownerBadgeLabel);
            summaryCard.Controls.Add(summarySeparator);
            summaryCard.Controls.Add(projectsStatLabel);
            summaryCard.Controls.Add(projectsStatValueLabel);
            summaryCard.Controls.Add(openTasksStatLabel);
            summaryCard.Controls.Add(openTasksStatValueLabel);
            summaryCard.Controls.Add(completedStatLabel);
            summaryCard.Controls.Add(completedStatValueLabel);
            summaryCard.Location = new Point(32, 147);
            summaryCard.Margin = new Padding(3, 4, 3, 4);
            summaryCard.Name = "summaryCard";
            summaryCard.Size = new Size(343, 493);
            summaryCard.TabIndex = 2;
            // 
            // avatarLabel
            // 
            avatarLabel.BackColor = Color.FromArgb(229, 237, 252);
            avatarLabel.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            avatarLabel.ForeColor = Color.FromArgb(37, 83, 183);
            avatarLabel.Location = new Point(120, 40);
            avatarLabel.Name = "avatarLabel";
            avatarLabel.Size = new Size(101, 109);
            avatarLabel.TabIndex = 0;
            avatarLabel.Text = "Y";
            avatarLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profileNameLabel
            // 
            profileNameLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            profileNameLabel.ForeColor = Color.FromArgb(31, 41, 55);
            profileNameLabel.Location = new Point(23, 173);
            profileNameLabel.Name = "profileNameLabel";
            profileNameLabel.Size = new Size(295, 33);
            profileNameLabel.TabIndex = 1;
            profileNameLabel.Text = "Yousef Ramy";
            profileNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profileEmailLabel
            // 
            profileEmailLabel.Font = new Font("Segoe UI", 10F);
            profileEmailLabel.ForeColor = Color.FromArgb(100, 112, 138);
            profileEmailLabel.Location = new Point(23, 209);
            profileEmailLabel.Name = "profileEmailLabel";
            profileEmailLabel.Size = new Size(295, 29);
            profileEmailLabel.TabIndex = 2;
            profileEmailLabel.Text = "yousef@example.com";
            profileEmailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ownerBadgeLabel
            // 
            ownerBadgeLabel.BackColor = Color.FromArgb(239, 242, 248);
            ownerBadgeLabel.Font = new Font("Segoe UI", 9F);
            ownerBadgeLabel.ForeColor = Color.FromArgb(77, 89, 113);
            ownerBadgeLabel.Location = new Point(127, 243);
            ownerBadgeLabel.Name = "ownerBadgeLabel";
            ownerBadgeLabel.Size = new Size(87, 29);
            ownerBadgeLabel.TabIndex = 3;
            ownerBadgeLabel.Text = "Owner";
            ownerBadgeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // summarySeparator
            // 
            summarySeparator.BackColor = Color.FromArgb(224, 230, 240);
            summarySeparator.Location = new Point(23, 293);
            summarySeparator.Margin = new Padding(3, 4, 3, 4);
            summarySeparator.Name = "summarySeparator";
            summarySeparator.Size = new Size(295, 1);
            summarySeparator.TabIndex = 4;
            // 
            // projectsStatLabel
            // 
            projectsStatLabel.AutoSize = true;
            projectsStatLabel.Font = new Font("Segoe UI", 10F);
            projectsStatLabel.ForeColor = Color.FromArgb(100, 112, 138);
            projectsStatLabel.Location = new Point(23, 324);
            projectsStatLabel.Name = "projectsStatLabel";
            projectsStatLabel.Size = new Size(70, 23);
            projectsStatLabel.TabIndex = 5;
            projectsStatLabel.Text = "Projects";
            // 
            // projectsStatValueLabel
            // 
            projectsStatValueLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            projectsStatValueLabel.ForeColor = Color.FromArgb(31, 41, 55);
            projectsStatValueLabel.Location = new Point(269, 324);
            projectsStatValueLabel.Name = "projectsStatValueLabel";
            projectsStatValueLabel.Size = new Size(48, 25);
            projectsStatValueLabel.TabIndex = 6;
            projectsStatValueLabel.Text = "3";
            projectsStatValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // openTasksStatLabel
            // 
            openTasksStatLabel.AutoSize = true;
            openTasksStatLabel.Font = new Font("Segoe UI", 10F);
            openTasksStatLabel.ForeColor = Color.FromArgb(100, 112, 138);
            openTasksStatLabel.Location = new Point(23, 364);
            openTasksStatLabel.Name = "openTasksStatLabel";
            openTasksStatLabel.Size = new Size(94, 23);
            openTasksStatLabel.TabIndex = 7;
            openTasksStatLabel.Text = "Open tasks";
            // 
            // openTasksStatValueLabel
            // 
            openTasksStatValueLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            openTasksStatValueLabel.ForeColor = Color.FromArgb(31, 41, 55);
            openTasksStatValueLabel.Location = new Point(269, 364);
            openTasksStatValueLabel.Name = "openTasksStatValueLabel";
            openTasksStatValueLabel.Size = new Size(48, 25);
            openTasksStatValueLabel.TabIndex = 8;
            openTasksStatValueLabel.Text = "6";
            openTasksStatValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // completedStatLabel
            // 
            completedStatLabel.AutoSize = true;
            completedStatLabel.Font = new Font("Segoe UI", 10F);
            completedStatLabel.ForeColor = Color.FromArgb(100, 112, 138);
            completedStatLabel.Location = new Point(23, 404);
            completedStatLabel.Name = "completedStatLabel";
            completedStatLabel.Size = new Size(94, 23);
            completedStatLabel.TabIndex = 9;
            completedStatLabel.Text = "Completed";
            // 
            // completedStatValueLabel
            // 
            completedStatValueLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            completedStatValueLabel.ForeColor = Color.FromArgb(31, 41, 55);
            completedStatValueLabel.Location = new Point(269, 404);
            completedStatValueLabel.Name = "completedStatValueLabel";
            completedStatValueLabel.Size = new Size(48, 25);
            completedStatValueLabel.TabIndex = 10;
            completedStatValueLabel.Text = "2";
            completedStatValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // accountCard
            // 
            accountCard.BackColor = Color.White;
            accountCard.BorderStyle = BorderStyle.FixedSingle;
            accountCard.Controls.Add(accountTitleLabel);
            accountCard.Controls.Add(fullNameLabel);
            accountCard.Controls.Add(fullNameTextBox);
            accountCard.Controls.Add(usernameLabel);
            accountCard.Controls.Add(usernameTextBox);
            accountCard.Controls.Add(emailLabel);
            accountCard.Controls.Add(emailTextBox);
            accountCard.Controls.Add(saveChangesButton);
            accountCard.Location = new Point(398, 147);
            accountCard.Margin = new Padding(3, 4, 3, 4);
            accountCard.Name = "accountCard";
            accountCard.Size = new Size(768, 399);
            accountCard.TabIndex = 3;
            // 
            // accountTitleLabel
            // 
            accountTitleLabel.AutoSize = true;
            accountTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            accountTitleLabel.ForeColor = Color.FromArgb(31, 41, 55);
            accountTitleLabel.Location = new Point(25, 23);
            accountTitleLabel.Name = "accountTitleLabel";
            accountTitleLabel.Size = new Size(159, 28);
            accountTitleLabel.TabIndex = 0;
            accountTitleLabel.Text = "Account details";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI", 9F);
            fullNameLabel.ForeColor = Color.FromArgb(100, 112, 138);
            fullNameLabel.Location = new Point(25, 68);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(73, 20);
            fullNameLabel.TabIndex = 1;
            fullNameLabel.Text = "Full name";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            fullNameTextBox.Font = new Font("Segoe UI", 10F);
            fullNameTextBox.Location = new Point(25, 92);
            fullNameTextBox.Margin = new Padding(3, 4, 3, 4);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(717, 30);
            fullNameTextBox.TabIndex = 2;
            fullNameTextBox.Text = "Yousef Ramy";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9F);
            usernameLabel.ForeColor = Color.FromArgb(100, 112, 138);
            usernameLabel.Location = new Point(25, 168);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Font = new Font("Segoe UI", 10F);
            usernameTextBox.Location = new Point(25, 192);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(349, 30);
            usernameTextBox.TabIndex = 4;
            usernameTextBox.Text = "yousef";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9F);
            emailLabel.ForeColor = Color.FromArgb(100, 112, 138);
            emailLabel.Location = new Point(391, 168);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Segoe UI", 10F);
            emailTextBox.Location = new Point(391, 192);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(352, 30);
            emailTextBox.TabIndex = 6;
            emailTextBox.Text = "yousef@example.com";
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = Color.FromArgb(47, 111, 237);
            saveChangesButton.FlatAppearance.BorderSize = 0;
            saveChangesButton.FlatStyle = FlatStyle.Flat;
            saveChangesButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            saveChangesButton.ForeColor = Color.White;
            saveChangesButton.Location = new Point(578, 292);
            saveChangesButton.Margin = new Padding(3, 4, 3, 4);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(160, 53);
            saveChangesButton.TabIndex = 7;
            saveChangesButton.Text = "Save changes";
            saveChangesButton.UseVisualStyleBackColor = false;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // passwordCard
            // 
            passwordCard.BackColor = Color.White;
            passwordCard.BorderStyle = BorderStyle.FixedSingle;
            passwordCard.Controls.Add(passwordTitleLabel);
            passwordCard.Controls.Add(currentPasswordLabel);
            passwordCard.Controls.Add(currentPasswordTextBox);
            passwordCard.Controls.Add(newPasswordLabel);
            passwordCard.Controls.Add(newPasswordTextBox);
            passwordCard.Controls.Add(confirmPasswordLabel);
            passwordCard.Controls.Add(confirmPasswordTextBox);
            passwordCard.Controls.Add(passwordMismatchIconLabel);
            passwordCard.Controls.Add(passwordMismatchLabel);
            passwordCard.Controls.Add(passwordHelpLabel);
            passwordCard.Controls.Add(updatePasswordButton);
            passwordCard.Location = new Point(398, 573);
            passwordCard.Margin = new Padding(3, 4, 3, 4);
            passwordCard.Name = "passwordCard";
            passwordCard.Size = new Size(768, 479);
            passwordCard.TabIndex = 4;
            // 
            // passwordTitleLabel
            // 
            passwordTitleLabel.AutoSize = true;
            passwordTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            passwordTitleLabel.ForeColor = Color.FromArgb(31, 41, 55);
            passwordTitleLabel.Location = new Point(25, 23);
            passwordTitleLabel.Name = "passwordTitleLabel";
            passwordTitleLabel.Size = new Size(177, 28);
            passwordTitleLabel.TabIndex = 0;
            passwordTitleLabel.Text = "Change password";
            // 
            // currentPasswordLabel
            // 
            currentPasswordLabel.AutoSize = true;
            currentPasswordLabel.Font = new Font("Segoe UI", 9F);
            currentPasswordLabel.ForeColor = Color.FromArgb(100, 112, 138);
            currentPasswordLabel.Location = new Point(25, 68);
            currentPasswordLabel.Name = "currentPasswordLabel";
            currentPasswordLabel.Size = new Size(124, 20);
            currentPasswordLabel.TabIndex = 1;
            currentPasswordLabel.Text = "Current password";
            // 
            // currentPasswordTextBox
            // 
            currentPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            currentPasswordTextBox.Font = new Font("Segoe UI", 10F);
            currentPasswordTextBox.Location = new Point(25, 92);
            currentPasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            currentPasswordTextBox.Name = "currentPasswordTextBox";
            currentPasswordTextBox.PasswordChar = '●';
            currentPasswordTextBox.Size = new Size(717, 30);
            currentPasswordTextBox.TabIndex = 2;
            currentPasswordTextBox.Text = "Current123";
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Segoe UI", 9F);
            newPasswordLabel.ForeColor = Color.FromArgb(100, 112, 138);
            newPasswordLabel.Location = new Point(25, 167);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(106, 20);
            newPasswordLabel.TabIndex = 3;
            newPasswordLabel.Text = "New password";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            newPasswordTextBox.Font = new Font("Segoe UI", 10F);
            newPasswordTextBox.Location = new Point(25, 191);
            newPasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PasswordChar = '●';
            newPasswordTextBox.Size = new Size(349, 30);
            newPasswordTextBox.TabIndex = 4;
            newPasswordTextBox.Text = "Newpass123";
            newPasswordTextBox.TextChanged += passwordFields_TextChanged;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Segoe UI", 9F);
            confirmPasswordLabel.ForeColor = Color.FromArgb(100, 112, 138);
            confirmPasswordLabel.Location = new Point(391, 167);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(160, 20);
            confirmPasswordLabel.TabIndex = 5;
            confirmPasswordLabel.Text = "Confirm new password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = Color.FromArgb(255, 248, 248);
            confirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordTextBox.Font = new Font("Segoe UI", 10F);
            confirmPasswordTextBox.Location = new Point(391, 191);
            confirmPasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '●';
            confirmPasswordTextBox.Size = new Size(352, 30);
            confirmPasswordTextBox.TabIndex = 6;
            confirmPasswordTextBox.Text = "Different123";
            confirmPasswordTextBox.TextChanged += passwordFields_TextChanged;
            // 
            // passwordMismatchIconLabel
            // 
            passwordMismatchIconLabel.AutoSize = true;
            passwordMismatchIconLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            passwordMismatchIconLabel.ForeColor = Color.FromArgb(217, 54, 54);
            passwordMismatchIconLabel.Location = new Point(391, 241);
            passwordMismatchIconLabel.Name = "passwordMismatchIconLabel";
            passwordMismatchIconLabel.Size = new Size(18, 20);
            passwordMismatchIconLabel.TabIndex = 7;
            passwordMismatchIconLabel.Text = "●";
            // 
            // passwordMismatchLabel
            // 
            passwordMismatchLabel.AutoSize = true;
            passwordMismatchLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            passwordMismatchLabel.ForeColor = Color.FromArgb(185, 45, 45);
            passwordMismatchLabel.Location = new Point(410, 243);
            passwordMismatchLabel.Name = "passwordMismatchLabel";
            passwordMismatchLabel.Size = new Size(181, 20);
            passwordMismatchLabel.TabIndex = 8;
            passwordMismatchLabel.Text = "Passwords do not match";
            // 
            // passwordHelpLabel
            // 
            passwordHelpLabel.AutoSize = true;
            passwordHelpLabel.Font = new Font("Segoe UI", 9F);
            passwordHelpLabel.ForeColor = Color.FromArgb(100, 112, 138);
            passwordHelpLabel.Location = new Point(25, 296);
            passwordHelpLabel.Name = "passwordHelpLabel";
            passwordHelpLabel.Size = new Size(353, 20);
            passwordHelpLabel.TabIndex = 9;
            passwordHelpLabel.Text = "Use at least 8 characters, with a letter and a number.";
            // 
            // updatePasswordButton
            // 
            updatePasswordButton.BackColor = Color.FromArgb(47, 111, 237);
            updatePasswordButton.FlatAppearance.BorderSize = 0;
            updatePasswordButton.FlatStyle = FlatStyle.Flat;
            updatePasswordButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            updatePasswordButton.ForeColor = Color.White;
            updatePasswordButton.Location = new Point(555, 380);
            updatePasswordButton.Margin = new Padding(3, 4, 3, 4);
            updatePasswordButton.Name = "updatePasswordButton";
            updatePasswordButton.Size = new Size(183, 53);
            updatePasswordButton.TabIndex = 10;
            updatePasswordButton.Text = "Update password";
            updatePasswordButton.UseVisualStyleBackColor = false;
            updatePasswordButton.Click += updatePasswordButton_Click;
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(1463, 1055);
            Controls.Add(mainPanel);
            Controls.Add(sidebarPanel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(1479, 1018);
            Name = "profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            selectedProfilePanel.ResumeLayout(false);
            selectedProfilePanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            summaryCard.ResumeLayout(false);
            summaryCard.PerformLayout();
            accountCard.ResumeLayout(false);
            accountCard.PerformLayout();
            passwordCard.ResumeLayout(false);
            passwordCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
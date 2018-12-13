using System;
using System.Drawing;
using System.Windows.Forms;



namespace JumpMaid
{

    // Verweise System.Drawing und System.WindowsForms hinzugefügt 
    class Menu : Form   // ehem. Menü-Fenser... PIET KEINE UMLAUTE!
    {
        public Menu()
        {
            this.Text = "JumpMaid";
            this.BackColor = Color.White;

            InitializeComponent();


        }

        private void InitializeComponent()
        {
            Button Exit = new Button();
            Label labelExit = new Label();

            Button Load = new Button();
            Label labenLoad = new Label();

            Button Option = new Button();
            Label labelOption = new Label();

            Button StartnewGame = new Button();
            Label labelStartnewGame = new Label();




            Exit = new System.Windows.Forms.Button();
            labelExit = new System.Windows.Forms.Label();

            SuspendLayout();

            //Button Exit

            Exit.Location = new System.Drawing.Point(103, 149);
            Exit.Name = "Exit";
            Exit.Size = new System.Drawing.Size(110, 23);
            Exit.TabIndex = 0;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += new EventHandler(Exit_ende);  // Für denn BeendenButton als Event

            // Button Load

            Load.Location = new System.Drawing.Point(103, 75);
            Load.Name = "Load";
            Load.Size = new System.Drawing.Size(110, 23);
            Load.TabIndex = 0;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += new EventHandler(Load_Menü); // Für das laden der Spielstände

            //Button option
            Option.Location = new System.Drawing.Point(103, 112);
            Option.Name = "Option";
            Option.Size = new System.Drawing.Size(110, 23);
            Option.TabIndex = 0;
            Option.Text = "Option";
            Option.UseVisualStyleBackColor = true;
            Option.Click += new EventHandler(option_viel); // Für die Optionen

            //Button StartnewGame

            StartnewGame.Location = new System.Drawing.Point(103, 38);
            StartnewGame.Name = "Start new Game";
            StartnewGame.Size = new System.Drawing.Size(110, 23);
            StartnewGame.TabIndex = 0;
            StartnewGame.Text = "Start new Game";
            StartnewGame.UseVisualStyleBackColor = true;
            StartnewGame.Click += new EventHandler(StartnewGame_Button);

            //LabelExit

            labelExit.AutoSize = true;
            labelExit.Location = new System.Drawing.Point(125, 103);
            labelExit.Name = "LabelExit";
            labelExit.Size = new System.Drawing.Size(35, 13);
            labelExit.TabIndex = 1;

            //labenLoad

            labenLoad.AutoSize = true;
            labenLoad.Location = new System.Drawing.Point(125, 103);
            labenLoad.Name = "labenLoad";
            labenLoad.Size = new System.Drawing.Size(35, 13);
            labenLoad.TabIndex = 1;

            //labelOption

            labelOption.AutoSize = true;
            labelOption.Location = new System.Drawing.Point(125, 103);
            labelOption.Name = "labelOption";
            labelOption.Size = new System.Drawing.Size(35, 13);
            labelOption.TabIndex = 1;

            //LabelStartnewGame

            labelStartnewGame.AutoSize = true;
            labelStartnewGame.Location = new System.Drawing.Point(125, 103);
            labelStartnewGame.Name = "labelStartnewGame";
            labelStartnewGame.Size = new System.Drawing.Size(35, 13);
            labelStartnewGame.TabIndex = 1;

            // Bild Anzeigen

            //Image Hintergrund = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\JumpGirl\Hintergrund.jpg");
            //Graphics.DrawImage(Hintergrund,350 ,150,100,100);


            Controls.Add(Exit);
            Controls.Add(Option);
            Controls.Add(StartnewGame);
            Controls.Add(Load);
            Controls.Add(labelExit);


        }
        // Event zum Beenden des Menüs 
        private void Exit_ende(object sender, EventArgs e)
        {
            Close();
            // MessageBox.Show("Beenden wir das hier.");

        }

        private void Load_Menü(object sender, EventArgs e)
        {
            MessageBox.Show("Platzhalter für das Laden der Spielstände");
        }

        private void option_viel(object sender, EventArgs e)
        {
            MessageBox.Show("Für die Optionen der Platzahlter");

        }

        private void StartnewGame_Button(object sender, EventArgs e)
        {
            MessageBox.Show("Platzhalter für das neue Spiel");

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics test = e.Graphics;


        }






        //Bild/Logo
        //Spiel Starten
        //Spiel Laden
        //Optionen mit Slider
        //Beenden

        // Bei Bestimmten Untermenüs 
    }
}
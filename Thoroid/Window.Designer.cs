
namespace Thoroid
{
    partial class Window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPolygons = new System.Windows.Forms.RadioButton();
            this.radioButtonLines = new System.Windows.Forms.RadioButton();
            this.radioButtonPoints = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonHorizontal = new System.Windows.Forms.RadioButton();
            this.radioButtonProfile = new System.Windows.Forms.RadioButton();
            this.radioButtonOrthogonal = new System.Windows.Forms.RadioButton();
            this.radioButtonPerspective = new System.Windows.Forms.RadioButton();
            this.radioButtonAxonometric = new System.Windows.Forms.RadioButton();
            this.radioButtonOblique = new System.Windows.Forms.RadioButton();
            this.radioButtonUsual2D = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRadiusBig = new System.Windows.Forms.TextBox();
            this.textBoxRadiusSmall = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApproximationSmall = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApproximationBig = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveFromUs = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveToUs = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.textBoxMoveX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMoveY = new System.Windows.Forms.TextBox();
            this.textBoxMoveZ = new System.Windows.Forms.TextBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonScale = new System.Windows.Forms.Button();
            this.textBoxScaleZ = new System.Windows.Forms.TextBox();
            this.textBoxScaleY = new System.Windows.Forms.TextBox();
            this.textBoxScaleX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.textBoxRotateZ = new System.Windows.Forms.TextBox();
            this.textBoxRotateY = new System.Windows.Forms.TextBox();
            this.textBoxRotateX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAxonometryTheta = new System.Windows.Forms.TextBox();
            this.textBoxAxonometryPhi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxObliqueAlpha = new System.Windows.Forms.TextBox();
            this.textBoxObliqueL = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPerspectivePhi = new System.Windows.Forms.TextBox();
            this.textBoxPerspectiveD = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxPerspectiveRo = new System.Windows.Forms.TextBox();
            this.textBoxPerspectiveTheta = new System.Windows.Forms.TextBox();
            this.buttonAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(700, 711);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPolygons);
            this.groupBox1.Controls.Add(this.radioButtonLines);
            this.groupBox1.Controls.Add(this.radioButtonPoints);
            this.groupBox1.Location = new System.Drawing.Point(715, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonPolygons
            // 
            this.radioButtonPolygons.AutoSize = true;
            this.radioButtonPolygons.Location = new System.Drawing.Point(7, 65);
            this.radioButtonPolygons.Name = "radioButtonPolygons";
            this.radioButtonPolygons.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPolygons.TabIndex = 2;
            this.radioButtonPolygons.Text = "polygons";
            this.radioButtonPolygons.UseVisualStyleBackColor = true;
            this.radioButtonPolygons.CheckedChanged += new System.EventHandler(this.RadioButtonPolygons_CheckedChanged);
            // 
            // radioButtonLines
            // 
            this.radioButtonLines.AutoSize = true;
            this.radioButtonLines.Checked = true;
            this.radioButtonLines.Location = new System.Drawing.Point(7, 42);
            this.radioButtonLines.Name = "radioButtonLines";
            this.radioButtonLines.Size = new System.Drawing.Size(46, 17);
            this.radioButtonLines.TabIndex = 1;
            this.radioButtonLines.TabStop = true;
            this.radioButtonLines.Text = "lines";
            this.radioButtonLines.UseVisualStyleBackColor = true;
            this.radioButtonLines.CheckedChanged += new System.EventHandler(this.RadioButtonLines_CheckedChanged);
            // 
            // radioButtonPoints
            // 
            this.radioButtonPoints.AutoSize = true;
            this.radioButtonPoints.Location = new System.Drawing.Point(7, 20);
            this.radioButtonPoints.Name = "radioButtonPoints";
            this.radioButtonPoints.Size = new System.Drawing.Size(71, 17);
            this.radioButtonPoints.TabIndex = 0;
            this.radioButtonPoints.Text = "realPoints";
            this.radioButtonPoints.UseVisualStyleBackColor = true;
            this.radioButtonPoints.CheckedChanged += new System.EventHandler(this.RadioButtonPoints_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonHorizontal);
            this.groupBox2.Controls.Add(this.radioButtonProfile);
            this.groupBox2.Controls.Add(this.radioButtonOrthogonal);
            this.groupBox2.Controls.Add(this.radioButtonPerspective);
            this.groupBox2.Controls.Add(this.radioButtonAxonometric);
            this.groupBox2.Controls.Add(this.radioButtonOblique);
            this.groupBox2.Controls.Add(this.radioButtonUsual2D);
            this.groupBox2.Location = new System.Drawing.Point(832, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonHorizontal
            // 
            this.radioButtonHorizontal.AutoSize = true;
            this.radioButtonHorizontal.Location = new System.Drawing.Point(98, 64);
            this.radioButtonHorizontal.Name = "radioButtonHorizontal";
            this.radioButtonHorizontal.Size = new System.Drawing.Size(72, 17);
            this.radioButtonHorizontal.TabIndex = 6;
            this.radioButtonHorizontal.Text = "Horizontal";
            this.radioButtonHorizontal.UseVisualStyleBackColor = true;
            this.radioButtonHorizontal.CheckedChanged += new System.EventHandler(this.RadioButtonHorizontal_CheckedChanged);
            // 
            // radioButtonProfile
            // 
            this.radioButtonProfile.AutoSize = true;
            this.radioButtonProfile.Location = new System.Drawing.Point(98, 41);
            this.radioButtonProfile.Name = "radioButtonProfile";
            this.radioButtonProfile.Size = new System.Drawing.Size(54, 17);
            this.radioButtonProfile.TabIndex = 5;
            this.radioButtonProfile.Text = "Profile";
            this.radioButtonProfile.UseVisualStyleBackColor = true;
            this.radioButtonProfile.CheckedChanged += new System.EventHandler(this.RadioButtonProfile_CheckedChanged);
            // 
            // radioButtonOrthogonal
            // 
            this.radioButtonOrthogonal.AutoSize = true;
            this.radioButtonOrthogonal.Location = new System.Drawing.Point(98, 19);
            this.radioButtonOrthogonal.Name = "radioButtonOrthogonal";
            this.radioButtonOrthogonal.Size = new System.Drawing.Size(77, 17);
            this.radioButtonOrthogonal.TabIndex = 4;
            this.radioButtonOrthogonal.Text = "Orthogonal";
            this.radioButtonOrthogonal.UseVisualStyleBackColor = true;
            this.radioButtonOrthogonal.CheckedChanged += new System.EventHandler(this.RadioButtonOrthogonal_CheckedChanged);
            // 
            // radioButtonPerspective
            // 
            this.radioButtonPerspective.AutoSize = true;
            this.radioButtonPerspective.Location = new System.Drawing.Point(7, 88);
            this.radioButtonPerspective.Name = "radioButtonPerspective";
            this.radioButtonPerspective.Size = new System.Drawing.Size(81, 17);
            this.radioButtonPerspective.TabIndex = 3;
            this.radioButtonPerspective.Text = "Perspective";
            this.radioButtonPerspective.UseVisualStyleBackColor = true;
            this.radioButtonPerspective.CheckedChanged += new System.EventHandler(this.RadioButtonPerspective_CheckedChanged);
            // 
            // radioButtonAxonometric
            // 
            this.radioButtonAxonometric.AutoSize = true;
            this.radioButtonAxonometric.Location = new System.Drawing.Point(7, 65);
            this.radioButtonAxonometric.Name = "radioButtonAxonometric";
            this.radioButtonAxonometric.Size = new System.Drawing.Size(83, 17);
            this.radioButtonAxonometric.TabIndex = 2;
            this.radioButtonAxonometric.Text = "Axonometric";
            this.radioButtonAxonometric.UseVisualStyleBackColor = true;
            this.radioButtonAxonometric.CheckedChanged += new System.EventHandler(this.RadioButtonAxonometric_CheckedChanged);
            // 
            // radioButtonOblique
            // 
            this.radioButtonOblique.AutoSize = true;
            this.radioButtonOblique.Location = new System.Drawing.Point(7, 42);
            this.radioButtonOblique.Name = "radioButtonOblique";
            this.radioButtonOblique.Size = new System.Drawing.Size(61, 17);
            this.radioButtonOblique.TabIndex = 1;
            this.radioButtonOblique.Text = "Oblique";
            this.radioButtonOblique.UseVisualStyleBackColor = true;
            this.radioButtonOblique.CheckedChanged += new System.EventHandler(this.RadioButtonOblique_CheckedChanged);
            // 
            // radioButtonUsual2D
            // 
            this.radioButtonUsual2D.AutoSize = true;
            this.radioButtonUsual2D.Checked = true;
            this.radioButtonUsual2D.Location = new System.Drawing.Point(7, 20);
            this.radioButtonUsual2D.Name = "radioButtonUsual2D";
            this.radioButtonUsual2D.Size = new System.Drawing.Size(70, 17);
            this.radioButtonUsual2D.TabIndex = 0;
            this.radioButtonUsual2D.TabStop = true;
            this.radioButtonUsual2D.Text = "usual_2D";
            this.radioButtonUsual2D.UseVisualStyleBackColor = true;
            this.radioButtonUsual2D.CheckedChanged += new System.EventHandler(this.RadioButtonUsual2D_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // textBoxRadiusBig
            // 
            this.textBoxRadiusBig.Location = new System.Drawing.Point(758, 180);
            this.textBoxRadiusBig.Name = "textBoxRadiusBig";
            this.textBoxRadiusBig.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadiusBig.TabIndex = 5;
            this.textBoxRadiusBig.Text = "100";
            // 
            // textBoxRadiusSmall
            // 
            this.textBoxRadiusSmall.Location = new System.Drawing.Point(758, 206);
            this.textBoxRadiusSmall.Name = "textBoxRadiusSmall";
            this.textBoxRadiusSmall.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadiusSmall.TabIndex = 7;
            this.textBoxRadiusSmall.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "r";
            // 
            // textBoxApproximationSmall
            // 
            this.textBoxApproximationSmall.Location = new System.Drawing.Point(930, 206);
            this.textBoxApproximationSmall.Name = "textBoxApproximationSmall";
            this.textBoxApproximationSmall.Size = new System.Drawing.Size(100, 20);
            this.textBoxApproximationSmall.TabIndex = 11;
            this.textBoxApproximationSmall.Text = "40";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(882, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "n";
            // 
            // textBoxApproximationBig
            // 
            this.textBoxApproximationBig.Location = new System.Drawing.Point(930, 180);
            this.textBoxApproximationBig.Name = "textBoxApproximationBig";
            this.textBoxApproximationBig.Size = new System.Drawing.Size(100, 20);
            this.textBoxApproximationBig.TabIndex = 9;
            this.textBoxApproximationBig.Text = "40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(882, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "N";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(707, 248);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(323, 23);
            this.buttonDraw.TabIndex = 12;
            this.buttonDraw.Text = "draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(707, 277);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(323, 23);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(832, 322);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveUp.TabIndex = 14;
            this.buttonMoveUp.Text = "up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.ButtonMoveUp_Click);
            // 
            // buttonMoveFromUs
            // 
            this.buttonMoveFromUs.Location = new System.Drawing.Point(927, 322);
            this.buttonMoveFromUs.Name = "buttonMoveFromUs";
            this.buttonMoveFromUs.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveFromUs.TabIndex = 15;
            this.buttonMoveFromUs.Text = "from us";
            this.buttonMoveFromUs.UseVisualStyleBackColor = true;
            this.buttonMoveFromUs.Click += new System.EventHandler(this.ButtonMoveFromUs_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Location = new System.Drawing.Point(927, 351);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveRight.TabIndex = 16;
            this.buttonMoveRight.Text = "right";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.ButtonMoveRight_Click);
            // 
            // buttonMoveToUs
            // 
            this.buttonMoveToUs.Location = new System.Drawing.Point(735, 380);
            this.buttonMoveToUs.Name = "buttonMoveToUs";
            this.buttonMoveToUs.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveToUs.TabIndex = 18;
            this.buttonMoveToUs.Text = "to us";
            this.buttonMoveToUs.UseVisualStyleBackColor = true;
            this.buttonMoveToUs.Click += new System.EventHandler(this.ButtonMoveToUs_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Location = new System.Drawing.Point(735, 351);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveLeft.TabIndex = 17;
            this.buttonMoveLeft.Text = "left";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.ButtonMoveLeft_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(832, 380);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveDown.TabIndex = 19;
            this.buttonMoveDown.Text = "down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.ButtonMoveDown_Click);
            // 
            // textBoxMoveX
            // 
            this.textBoxMoveX.Location = new System.Drawing.Point(750, 409);
            this.textBoxMoveX.Name = "textBoxMoveX";
            this.textBoxMoveX.Size = new System.Drawing.Size(76, 20);
            this.textBoxMoveX.TabIndex = 21;
            this.textBoxMoveX.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Move";
            // 
            // textBoxMoveY
            // 
            this.textBoxMoveY.Location = new System.Drawing.Point(832, 409);
            this.textBoxMoveY.Name = "textBoxMoveY";
            this.textBoxMoveY.Size = new System.Drawing.Size(70, 20);
            this.textBoxMoveY.TabIndex = 22;
            this.textBoxMoveY.Text = "30";
            // 
            // textBoxMoveZ
            // 
            this.textBoxMoveZ.Location = new System.Drawing.Point(908, 409);
            this.textBoxMoveZ.Name = "textBoxMoveZ";
            this.textBoxMoveZ.Size = new System.Drawing.Size(71, 20);
            this.textBoxMoveZ.TabIndex = 23;
            this.textBoxMoveZ.Text = "30";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(985, 407);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(37, 23);
            this.buttonMove.TabIndex = 24;
            this.buttonMove.Text = "OK";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(985, 433);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(37, 23);
            this.buttonScale.TabIndex = 29;
            this.buttonScale.Text = "OK";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.ButtonScale_Click);
            // 
            // textBoxScaleZ
            // 
            this.textBoxScaleZ.Location = new System.Drawing.Point(908, 435);
            this.textBoxScaleZ.Name = "textBoxScaleZ";
            this.textBoxScaleZ.Size = new System.Drawing.Size(71, 20);
            this.textBoxScaleZ.TabIndex = 28;
            this.textBoxScaleZ.Text = "1.5";
            // 
            // textBoxScaleY
            // 
            this.textBoxScaleY.Location = new System.Drawing.Point(832, 435);
            this.textBoxScaleY.Name = "textBoxScaleY";
            this.textBoxScaleY.Size = new System.Drawing.Size(70, 20);
            this.textBoxScaleY.TabIndex = 27;
            this.textBoxScaleY.Text = "1.5";
            // 
            // textBoxScaleX
            // 
            this.textBoxScaleX.Location = new System.Drawing.Point(750, 435);
            this.textBoxScaleX.Name = "textBoxScaleX";
            this.textBoxScaleX.Size = new System.Drawing.Size(76, 20);
            this.textBoxScaleX.TabIndex = 26;
            this.textBoxScaleX.Text = "1.5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Scale";
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(985, 459);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(37, 23);
            this.buttonRotate.TabIndex = 34;
            this.buttonRotate.Text = "OK";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.ButtonRotate_Click);
            // 
            // textBoxRotateZ
            // 
            this.textBoxRotateZ.Location = new System.Drawing.Point(908, 461);
            this.textBoxRotateZ.Name = "textBoxRotateZ";
            this.textBoxRotateZ.Size = new System.Drawing.Size(71, 20);
            this.textBoxRotateZ.TabIndex = 33;
            this.textBoxRotateZ.Text = "30";
            // 
            // textBoxRotateY
            // 
            this.textBoxRotateY.Location = new System.Drawing.Point(832, 461);
            this.textBoxRotateY.Name = "textBoxRotateY";
            this.textBoxRotateY.Size = new System.Drawing.Size(70, 20);
            this.textBoxRotateY.TabIndex = 32;
            this.textBoxRotateY.Text = "30";
            // 
            // textBoxRotateX
            // 
            this.textBoxRotateX.Location = new System.Drawing.Point(750, 461);
            this.textBoxRotateX.Name = "textBoxRotateX";
            this.textBoxRotateX.Size = new System.Drawing.Size(76, 20);
            this.textBoxRotateX.TabIndex = 31;
            this.textBoxRotateX.Text = "30";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Rotate";
            // 
            // textBoxAxonometryTheta
            // 
            this.textBoxAxonometryTheta.Location = new System.Drawing.Point(713, 547);
            this.textBoxAxonometryTheta.Name = "textBoxAxonometryTheta";
            this.textBoxAxonometryTheta.Size = new System.Drawing.Size(97, 20);
            this.textBoxAxonometryTheta.TabIndex = 36;
            this.textBoxAxonometryTheta.Text = "30";
            // 
            // textBoxAxonometryPhi
            // 
            this.textBoxAxonometryPhi.Location = new System.Drawing.Point(713, 521);
            this.textBoxAxonometryPhi.Name = "textBoxAxonometryPhi";
            this.textBoxAxonometryPhi.Size = new System.Drawing.Size(97, 20);
            this.textBoxAxonometryPhi.TabIndex = 35;
            this.textBoxAxonometryPhi.Text = "30";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(816, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "theta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(816, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "phi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(718, 493);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Axonometry";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(718, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Oblique";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(816, 633);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "alpha";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(816, 607);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "L";
            // 
            // textBoxObliqueAlpha
            // 
            this.textBoxObliqueAlpha.Location = new System.Drawing.Point(713, 630);
            this.textBoxObliqueAlpha.Name = "textBoxObliqueAlpha";
            this.textBoxObliqueAlpha.Size = new System.Drawing.Size(97, 20);
            this.textBoxObliqueAlpha.TabIndex = 41;
            this.textBoxObliqueAlpha.Text = "30";
            // 
            // textBoxObliqueL
            // 
            this.textBoxObliqueL.Location = new System.Drawing.Point(713, 604);
            this.textBoxObliqueL.Name = "textBoxObliqueL";
            this.textBoxObliqueL.Size = new System.Drawing.Size(97, 20);
            this.textBoxObliqueL.TabIndex = 40;
            this.textBoxObliqueL.Text = "0.5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(891, 493);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 49;
            this.label14.Text = "Perspective";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(989, 550);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "phi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(989, 524);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "d";
            // 
            // textBoxPerspectivePhi
            // 
            this.textBoxPerspectivePhi.Location = new System.Drawing.Point(886, 547);
            this.textBoxPerspectivePhi.Name = "textBoxPerspectivePhi";
            this.textBoxPerspectivePhi.Size = new System.Drawing.Size(97, 20);
            this.textBoxPerspectivePhi.TabIndex = 46;
            this.textBoxPerspectivePhi.Text = "30";
            // 
            // textBoxPerspectiveD
            // 
            this.textBoxPerspectiveD.Location = new System.Drawing.Point(886, 521);
            this.textBoxPerspectiveD.Name = "textBoxPerspectiveD";
            this.textBoxPerspectiveD.Size = new System.Drawing.Size(97, 20);
            this.textBoxPerspectiveD.TabIndex = 45;
            this.textBoxPerspectiveD.Text = "30";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(989, 602);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "ro";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(989, 576);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "theta";
            // 
            // textBoxPerspectiveRo
            // 
            this.textBoxPerspectiveRo.Location = new System.Drawing.Point(886, 599);
            this.textBoxPerspectiveRo.Name = "textBoxPerspectiveRo";
            this.textBoxPerspectiveRo.Size = new System.Drawing.Size(97, 20);
            this.textBoxPerspectiveRo.TabIndex = 51;
            this.textBoxPerspectiveRo.Text = "200";
            // 
            // textBoxPerspectiveTheta
            // 
            this.textBoxPerspectiveTheta.Location = new System.Drawing.Point(886, 573);
            this.textBoxPerspectiveTheta.Name = "textBoxPerspectiveTheta";
            this.textBoxPerspectiveTheta.Size = new System.Drawing.Size(97, 20);
            this.textBoxPerspectiveTheta.TabIndex = 50;
            this.textBoxPerspectiveTheta.Text = "30";
            // 
            // buttonAuto
            // 
            this.buttonAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuto.Location = new System.Drawing.Point(893, 649);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(129, 50);
            this.buttonAuto.TabIndex = 54;
            this.buttonAuto.Text = "AUTO";
            this.buttonAuto.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 711);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxPerspectiveRo);
            this.Controls.Add(this.textBoxPerspectiveTheta);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxPerspectivePhi);
            this.Controls.Add(this.textBoxPerspectiveD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxObliqueAlpha);
            this.Controls.Add(this.textBoxObliqueL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAxonometryTheta);
            this.Controls.Add(this.textBoxAxonometryPhi);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.textBoxRotateZ);
            this.Controls.Add(this.textBoxRotateY);
            this.Controls.Add(this.textBoxRotateX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonScale);
            this.Controls.Add(this.textBoxScaleZ);
            this.Controls.Add(this.textBoxScaleY);
            this.Controls.Add(this.textBoxScaleX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.textBoxMoveZ);
            this.Controls.Add(this.textBoxMoveY);
            this.Controls.Add(this.textBoxMoveX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonMoveToUs);
            this.Controls.Add(this.buttonMoveLeft);
            this.Controls.Add(this.buttonMoveRight);
            this.Controls.Add(this.buttonMoveFromUs);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.textBoxApproximationSmall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxApproximationBig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRadiusSmall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRadiusBig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thoroid";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonPolygons;
        private System.Windows.Forms.RadioButton radioButtonLines;
        private System.Windows.Forms.RadioButton radioButtonPoints;
        private System.Windows.Forms.RadioButton radioButtonHorizontal;
        private System.Windows.Forms.RadioButton radioButtonProfile;
        private System.Windows.Forms.RadioButton radioButtonOrthogonal;
        private System.Windows.Forms.RadioButton radioButtonPerspective;
        private System.Windows.Forms.RadioButton radioButtonAxonometric;
        private System.Windows.Forms.RadioButton radioButtonOblique;
        private System.Windows.Forms.RadioButton radioButtonUsual2D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxRadiusBig;
        private System.Windows.Forms.TextBox textBoxRadiusSmall;
        private System.Windows.Forms.TextBox textBoxApproximationSmall;
        private System.Windows.Forms.TextBox textBoxApproximationBig;
        private System.Windows.Forms.TextBox textBoxMoveX;
        private System.Windows.Forms.TextBox textBoxMoveY;
        private System.Windows.Forms.TextBox textBoxMoveZ;
        private System.Windows.Forms.TextBox textBoxScaleZ;
        private System.Windows.Forms.TextBox textBoxScaleY;
        private System.Windows.Forms.TextBox textBoxScaleX;
        private System.Windows.Forms.TextBox textBoxRotateZ;
        private System.Windows.Forms.TextBox textBoxRotateY;
        private System.Windows.Forms.TextBox textBoxRotateX;
        private System.Windows.Forms.TextBox textBoxAxonometryTheta;
        private System.Windows.Forms.TextBox textBoxAxonometryPhi;
        private System.Windows.Forms.TextBox textBoxObliqueAlpha;
        private System.Windows.Forms.TextBox textBoxObliqueL;
        private System.Windows.Forms.TextBox textBoxPerspectivePhi;
        private System.Windows.Forms.TextBox textBoxPerspectiveD;
        private System.Windows.Forms.TextBox textBoxPerspectiveRo;
        private System.Windows.Forms.TextBox textBoxPerspectiveTheta;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveFromUs;
        private System.Windows.Forms.Button buttonMoveToUs;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonAuto;
    }
}


namespace CagriMerkezi
{
    partial class cagriMerkeziForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aramaTicari = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.musteriEkrani = new System.Windows.Forms.TabPage();
            this.aramaBitirmeLabel = new System.Windows.Forms.Label();
            this.aramaBitir = new System.Windows.Forms.Button();
            this.siraSorgulama = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.musteri_id_text = new System.Windows.Forms.TextBox();
            this.siraSorgulamaLabel = new System.Windows.Forms.Label();
            this.cizgi = new System.Windows.Forms.ProgressBar();
            this.aramaYapmaLabel = new System.Windows.Forms.Label();
            this.aramaBireysel = new System.Windows.Forms.Button();
            this.cagriTemsilcisiEkrani = new System.Windows.Forms.TabPage();
            this.notAramaLabel = new System.Windows.Forms.Label();
            this.kelimeText = new System.Windows.Forms.TextBox();
            this.kelimeArama = new System.Windows.Forms.Button();
            this.notLabel = new System.Windows.Forms.Label();
            this.notText = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.cagriAtamaLabel = new System.Windows.Forms.Label();
            this.cagriAtamaBireysel = new System.Windows.Forms.Button();
            this.cagriAtamaTicari = new System.Windows.Forms.Button();
            this.siraEkrani = new System.Windows.Forms.TabPage();
            this.TMlistView = new System.Windows.Forms.ListView();
            this.BMlistView = new System.Windows.Forms.ListView();
            this.bmsLabel = new System.Windows.Forms.Label();
            this.tmsLabel = new System.Windows.Forms.Label();
            this.gorusmeEkrani = new System.Windows.Forms.TabPage();
            this.Gorusme_listView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.musteriEkrani.SuspendLayout();
            this.cagriTemsilcisiEkrani.SuspendLayout();
            this.siraEkrani.SuspendLayout();
            this.gorusmeEkrani.SuspendLayout();
            this.SuspendLayout();
            // 
            // aramaTicari
            // 
            this.aramaTicari.Location = new System.Drawing.Point(48, 61);
            this.aramaTicari.Name = "aramaTicari";
            this.aramaTicari.Size = new System.Drawing.Size(251, 75);
            this.aramaTicari.TabIndex = 0;
            this.aramaTicari.Text = "ARAMA YAP\r\n(TİCARİ MÜŞTERİYİM)";
            this.aramaTicari.UseVisualStyleBackColor = true;
            this.aramaTicari.Click += new System.EventHandler(this.aramaTicari_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.musteriEkrani);
            this.tabControl.Controls.Add(this.cagriTemsilcisiEkrani);
            this.tabControl.Controls.Add(this.siraEkrani);
            this.tabControl.Controls.Add(this.gorusmeEkrani);
            this.tabControl.Location = new System.Drawing.Point(23, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(769, 525);
            this.tabControl.TabIndex = 2;
            // 
            // musteriEkrani
            // 
            this.musteriEkrani.Controls.Add(this.aramaBitirmeLabel);
            this.musteriEkrani.Controls.Add(this.aramaBitir);
            this.musteriEkrani.Controls.Add(this.siraSorgulama);
            this.musteriEkrani.Controls.Add(this.id);
            this.musteriEkrani.Controls.Add(this.musteri_id_text);
            this.musteriEkrani.Controls.Add(this.siraSorgulamaLabel);
            this.musteriEkrani.Controls.Add(this.cizgi);
            this.musteriEkrani.Controls.Add(this.aramaYapmaLabel);
            this.musteriEkrani.Controls.Add(this.aramaBireysel);
            this.musteriEkrani.Controls.Add(this.aramaTicari);
            this.musteriEkrani.Location = new System.Drawing.Point(4, 25);
            this.musteriEkrani.Name = "musteriEkrani";
            this.musteriEkrani.Padding = new System.Windows.Forms.Padding(3);
            this.musteriEkrani.Size = new System.Drawing.Size(761, 496);
            this.musteriEkrani.TabIndex = 0;
            this.musteriEkrani.Text = "Müşteri Ekranı";
            this.musteriEkrani.UseVisualStyleBackColor = true;
            // 
            // aramaBitirmeLabel
            // 
            this.aramaBitirmeLabel.AutoSize = true;
            this.aramaBitirmeLabel.Location = new System.Drawing.Point(449, 324);
            this.aramaBitirmeLabel.Name = "aramaBitirmeLabel";
            this.aramaBitirmeLabel.Size = new System.Drawing.Size(92, 16);
            this.aramaBitirmeLabel.TabIndex = 10;
            this.aramaBitirmeLabel.Text = "ARAMA BİTİR";
            // 
            // aramaBitir
            // 
            this.aramaBitir.Location = new System.Drawing.Point(452, 343);
            this.aramaBitir.Name = "aramaBitir";
            this.aramaBitir.Size = new System.Drawing.Size(251, 75);
            this.aramaBitir.TabIndex = 9;
            this.aramaBitir.Text = "ARAMAYI BİTİR\r\n";
            this.aramaBitir.UseVisualStyleBackColor = true;
            this.aramaBitir.Click += new System.EventHandler(this.aramaBitir_Click);
            // 
            // siraSorgulama
            // 
            this.siraSorgulama.Location = new System.Drawing.Point(48, 343);
            this.siraSorgulama.Name = "siraSorgulama";
            this.siraSorgulama.Size = new System.Drawing.Size(251, 75);
            this.siraSorgulama.TabIndex = 7;
            this.siraSorgulama.Text = "SORGULA";
            this.siraSorgulama.UseVisualStyleBackColor = true;
            this.siraSorgulama.Click += new System.EventHandler(this.siraSorgulama_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(226, 251);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(69, 16);
            this.id.TabIndex = 6;
            this.id.Text = "Müşteri ID:";
            // 
            // musteri_id_text
            // 
            this.musteri_id_text.Location = new System.Drawing.Point(298, 248);
            this.musteri_id_text.Name = "musteri_id_text";
            this.musteri_id_text.Size = new System.Drawing.Size(158, 22);
            this.musteri_id_text.TabIndex = 5;
            // 
            // siraSorgulamaLabel
            // 
            this.siraSorgulamaLabel.AutoSize = true;
            this.siraSorgulamaLabel.Location = new System.Drawing.Point(45, 324);
            this.siraSorgulamaLabel.Name = "siraSorgulamaLabel";
            this.siraSorgulamaLabel.Size = new System.Drawing.Size(106, 16);
            this.siraSorgulamaLabel.TabIndex = 4;
            this.siraSorgulamaLabel.Text = "SIRA SORGULA";
            // 
            // cizgi
            // 
            this.cizgi.Location = new System.Drawing.Point(0, 196);
            this.cizgi.Name = "cizgi";
            this.cizgi.Size = new System.Drawing.Size(761, 10);
            this.cizgi.TabIndex = 3;
            // 
            // aramaYapmaLabel
            // 
            this.aramaYapmaLabel.AutoSize = true;
            this.aramaYapmaLabel.Location = new System.Drawing.Point(45, 23);
            this.aramaYapmaLabel.Name = "aramaYapmaLabel";
            this.aramaYapmaLabel.Size = new System.Drawing.Size(85, 16);
            this.aramaYapmaLabel.TabIndex = 2;
            this.aramaYapmaLabel.Text = "ARAMA YAP";
            // 
            // aramaBireysel
            // 
            this.aramaBireysel.Location = new System.Drawing.Point(452, 61);
            this.aramaBireysel.Name = "aramaBireysel";
            this.aramaBireysel.Size = new System.Drawing.Size(251, 75);
            this.aramaBireysel.TabIndex = 1;
            this.aramaBireysel.Text = "ARAMA YAP\r\n(BİREYSEL MÜŞTERİYİM)";
            this.aramaBireysel.UseVisualStyleBackColor = true;
            this.aramaBireysel.Click += new System.EventHandler(this.aramaBireysel_Click);
            // 
            // cagriTemsilcisiEkrani
            // 
            this.cagriTemsilcisiEkrani.Controls.Add(this.notAramaLabel);
            this.cagriTemsilcisiEkrani.Controls.Add(this.kelimeText);
            this.cagriTemsilcisiEkrani.Controls.Add(this.kelimeArama);
            this.cagriTemsilcisiEkrani.Controls.Add(this.notLabel);
            this.cagriTemsilcisiEkrani.Controls.Add(this.notText);
            this.cagriTemsilcisiEkrani.Controls.Add(this.progressBar2);
            this.cagriTemsilcisiEkrani.Controls.Add(this.cagriAtamaLabel);
            this.cagriTemsilcisiEkrani.Controls.Add(this.cagriAtamaBireysel);
            this.cagriTemsilcisiEkrani.Controls.Add(this.cagriAtamaTicari);
            this.cagriTemsilcisiEkrani.Location = new System.Drawing.Point(4, 25);
            this.cagriTemsilcisiEkrani.Name = "cagriTemsilcisiEkrani";
            this.cagriTemsilcisiEkrani.Padding = new System.Windows.Forms.Padding(3);
            this.cagriTemsilcisiEkrani.Size = new System.Drawing.Size(761, 496);
            this.cagriTemsilcisiEkrani.TabIndex = 1;
            this.cagriTemsilcisiEkrani.Text = "Çağrı Temsilcisi Ekranı";
            this.cagriTemsilcisiEkrani.UseVisualStyleBackColor = true;
            // 
            // notAramaLabel
            // 
            this.notAramaLabel.AutoSize = true;
            this.notAramaLabel.Location = new System.Drawing.Point(73, 418);
            this.notAramaLabel.Name = "notAramaLabel";
            this.notAramaLabel.Size = new System.Drawing.Size(224, 16);
            this.notAramaLabel.TabIndex = 14;
            this.notAramaLabel.Text = "Not içinde aramak istediğiniz kelime:";
            // 
            // kelimeText
            // 
            this.kelimeText.Location = new System.Drawing.Point(76, 437);
            this.kelimeText.Multiline = true;
            this.kelimeText.Name = "kelimeText";
            this.kelimeText.Size = new System.Drawing.Size(355, 22);
            this.kelimeText.TabIndex = 13;
            // 
            // kelimeArama
            // 
            this.kelimeArama.Location = new System.Drawing.Point(467, 428);
            this.kelimeArama.Name = "kelimeArama";
            this.kelimeArama.Size = new System.Drawing.Size(143, 31);
            this.kelimeArama.TabIndex = 12;
            this.kelimeArama.Text = "ARA";
            this.kelimeArama.UseVisualStyleBackColor = true;
            this.kelimeArama.Click += new System.EventHandler(this.kelimeArama_Click);
            // 
            // notLabel
            // 
            this.notLabel.AutoSize = true;
            this.notLabel.Location = new System.Drawing.Point(73, 170);
            this.notLabel.Name = "notLabel";
            this.notLabel.Size = new System.Drawing.Size(65, 16);
            this.notLabel.TabIndex = 11;
            this.notLabel.Text = "NOT YAZ";
            // 
            // notText
            // 
            this.notText.Location = new System.Drawing.Point(76, 199);
            this.notText.Multiline = true;
            this.notText.Name = "notText";
            this.notText.Size = new System.Drawing.Size(534, 173);
            this.notText.TabIndex = 10;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(0, 143);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(761, 10);
            this.progressBar2.TabIndex = 7;
            // 
            // cagriAtamaLabel
            // 
            this.cagriAtamaLabel.AutoSize = true;
            this.cagriAtamaLabel.Location = new System.Drawing.Point(73, 11);
            this.cagriAtamaLabel.Name = "cagriAtamaLabel";
            this.cagriAtamaLabel.Size = new System.Drawing.Size(78, 16);
            this.cagriAtamaLabel.TabIndex = 6;
            this.cagriAtamaLabel.Text = "ÇAĞRI ATA";
            // 
            // cagriAtamaBireysel
            // 
            this.cagriAtamaBireysel.Location = new System.Drawing.Point(359, 52);
            this.cagriAtamaBireysel.Name = "cagriAtamaBireysel";
            this.cagriAtamaBireysel.Size = new System.Drawing.Size(251, 75);
            this.cagriAtamaBireysel.TabIndex = 5;
            this.cagriAtamaBireysel.Text = "ÇAĞRI ATA \r\n(BİREYSEL MÜŞTERİ)";
            this.cagriAtamaBireysel.UseVisualStyleBackColor = true;
            this.cagriAtamaBireysel.Click += new System.EventHandler(this.cagriAtamaBireysel_Click);
            // 
            // cagriAtamaTicari
            // 
            this.cagriAtamaTicari.Location = new System.Drawing.Point(76, 52);
            this.cagriAtamaTicari.Name = "cagriAtamaTicari";
            this.cagriAtamaTicari.Size = new System.Drawing.Size(251, 75);
            this.cagriAtamaTicari.TabIndex = 4;
            this.cagriAtamaTicari.Text = "ÇAĞRI ATA\r\n(TİCARİ MÜŞTERİ)";
            this.cagriAtamaTicari.UseVisualStyleBackColor = true;
            this.cagriAtamaTicari.Click += new System.EventHandler(this.cagriAtamaTicari_Click);
            // 
            // siraEkrani
            // 
            this.siraEkrani.Controls.Add(this.TMlistView);
            this.siraEkrani.Controls.Add(this.BMlistView);
            this.siraEkrani.Controls.Add(this.bmsLabel);
            this.siraEkrani.Controls.Add(this.tmsLabel);
            this.siraEkrani.Location = new System.Drawing.Point(4, 25);
            this.siraEkrani.Name = "siraEkrani";
            this.siraEkrani.Size = new System.Drawing.Size(761, 496);
            this.siraEkrani.TabIndex = 2;
            this.siraEkrani.Text = "Sıra Ekranı";
            this.siraEkrani.UseVisualStyleBackColor = true;
            // 
            // TMlistView
            // 
            this.TMlistView.HideSelection = false;
            this.TMlistView.Location = new System.Drawing.Point(6, 31);
            this.TMlistView.Name = "TMlistView";
            this.TMlistView.Size = new System.Drawing.Size(749, 183);
            this.TMlistView.TabIndex = 17;
            this.TMlistView.UseCompatibleStateImageBehavior = false;
            this.TMlistView.View = System.Windows.Forms.View.List;
            // 
            // BMlistView
            // 
            this.BMlistView.HideSelection = false;
            this.BMlistView.Location = new System.Drawing.Point(6, 302);
            this.BMlistView.Name = "BMlistView";
            this.BMlistView.Size = new System.Drawing.Size(749, 183);
            this.BMlistView.TabIndex = 16;
            this.BMlistView.UseCompatibleStateImageBehavior = false;
            this.BMlistView.View = System.Windows.Forms.View.List;
            // 
            // bmsLabel
            // 
            this.bmsLabel.AutoSize = true;
            this.bmsLabel.Location = new System.Drawing.Point(6, 283);
            this.bmsLabel.Name = "bmsLabel";
            this.bmsLabel.Size = new System.Drawing.Size(196, 16);
            this.bmsLabel.TabIndex = 15;
            this.bmsLabel.Text = "Bireysel Müşteri Bekleme Sırası";
            // 
            // tmsLabel
            // 
            this.tmsLabel.AutoSize = true;
            this.tmsLabel.Location = new System.Drawing.Point(6, 12);
            this.tmsLabel.Name = "tmsLabel";
            this.tmsLabel.Size = new System.Drawing.Size(181, 16);
            this.tmsLabel.TabIndex = 14;
            this.tmsLabel.Text = "Ticari Müşteri Bekleme Sırası";
            // 
            // gorusmeEkrani
            // 
            this.gorusmeEkrani.Controls.Add(this.Gorusme_listView);
            this.gorusmeEkrani.Controls.Add(this.label2);
            this.gorusmeEkrani.Location = new System.Drawing.Point(4, 25);
            this.gorusmeEkrani.Name = "gorusmeEkrani";
            this.gorusmeEkrani.Padding = new System.Windows.Forms.Padding(3);
            this.gorusmeEkrani.Size = new System.Drawing.Size(761, 496);
            this.gorusmeEkrani.TabIndex = 3;
            this.gorusmeEkrani.Text = "Görüşme Ekranı";
            this.gorusmeEkrani.UseVisualStyleBackColor = true;
            // 
            // Gorusme_listView
            // 
            this.Gorusme_listView.HideSelection = false;
            this.Gorusme_listView.Location = new System.Drawing.Point(6, 79);
            this.Gorusme_listView.Name = "Gorusme_listView";
            this.Gorusme_listView.Size = new System.Drawing.Size(749, 411);
            this.Gorusme_listView.TabIndex = 21;
            this.Gorusme_listView.UseCompatibleStateImageBehavior = false;
            this.Gorusme_listView.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Görüşmede Olan Müşteriler\r\n";
            // 
            // cagriMerkeziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 574);
            this.Controls.Add(this.tabControl);
            this.Name = "cagriMerkeziForm";
            this.Text = "ÇAĞRI MERKEZİ";
            this.Load += new System.EventHandler(this.cagriMerkeziForm_Load);
            this.tabControl.ResumeLayout(false);
            this.musteriEkrani.ResumeLayout(false);
            this.musteriEkrani.PerformLayout();
            this.cagriTemsilcisiEkrani.ResumeLayout(false);
            this.cagriTemsilcisiEkrani.PerformLayout();
            this.siraEkrani.ResumeLayout(false);
            this.siraEkrani.PerformLayout();
            this.gorusmeEkrani.ResumeLayout(false);
            this.gorusmeEkrani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aramaTicari;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage musteriEkrani;
        private System.Windows.Forms.TabPage cagriTemsilcisiEkrani;
        private System.Windows.Forms.TabPage siraEkrani;
        private System.Windows.Forms.Button aramaBireysel;
        private System.Windows.Forms.ListView TMlistView;
        private System.Windows.Forms.ListView BMlistView;
        private System.Windows.Forms.Label bmsLabel;
        private System.Windows.Forms.Label tmsLabel;
        private System.Windows.Forms.Label siraSorgulamaLabel;
        private System.Windows.Forms.ProgressBar cizgi;
        private System.Windows.Forms.Label aramaYapmaLabel;
        private System.Windows.Forms.Button siraSorgulama;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox musteri_id_text;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label cagriAtamaLabel;
        private System.Windows.Forms.Button cagriAtamaBireysel;
        private System.Windows.Forms.Button cagriAtamaTicari;
        private System.Windows.Forms.TextBox notText;
        private System.Windows.Forms.Label notLabel;
        private System.Windows.Forms.Label notAramaLabel;
        private System.Windows.Forms.TextBox kelimeText;
        private System.Windows.Forms.Button kelimeArama;
        private System.Windows.Forms.Button aramaBitir;
        private System.Windows.Forms.Label aramaBitirmeLabel;
        private System.Windows.Forms.TabPage gorusmeEkrani;
        private System.Windows.Forms.ListView Gorusme_listView;
        private System.Windows.Forms.Label label2;
    }
}


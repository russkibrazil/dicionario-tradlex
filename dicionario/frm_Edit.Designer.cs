namespace dicionario
{
    partial class frm_Edit
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
            this.components = new System.ComponentModel.Container();
            this.txtpalavra = new System.Windows.Forms.TextBox();
            this.textCultura = new System.Windows.Forms.TextBox();
            this.txtGramatica = new System.Windows.Forms.TextBox();
            this.txtDefinicao = new System.Windows.Forms.TextBox();
            this.ComboGenero = new System.Windows.Forms.ComboBox();
            this.ComboIdioma = new System.Windows.Forms.ComboBox();
            this.ComboClasseGram = new System.Windows.Forms.ComboBox();
            this.label_palavra = new System.Windows.Forms.Label();
            this.label_cult = new System.Windows.Forms.Label();
            this.label_grammar = new System.Windows.Forms.Label();
            this.label_acep = new System.Windows.Forms.Label();
            this.label_catgrama = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.menu_barra = new System.Windows.Forms.MenuStrip();
            this.acessoRápidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tip_Dicas = new System.Windows.Forms.ToolTip(this.components);
            this.btnEquiv = new System.Windows.Forms.Button();
            this.btnConjuga = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboFiltroPrecisao = new System.Windows.Forms.ComboBox();
            this.comboFiltroIdiomas = new System.Windows.Forms.ComboBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btnFrase = new System.Windows.Forms.Button();
            this.menu_barra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpalavra
            // 
            this.txtpalavra.AutoCompleteCustomSource.AddRange(new string[] {
            "Country",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Côte d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Democratic People\'s Republic of Korea (North Korea)",
            "Democratic Republic of the Cong",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Lao People\'s Democratic Republic (Laos)",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia (Federated States of)",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Republic of Korea (South Korea)",
            "Republic of Moldova",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syrian Arab Republic",
            "Tajikistan",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom of Great Britain and Northern Ireland",
            "United Republic of Tanzania",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.txtpalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalavra.Location = new System.Drawing.Point(45, 152);
            this.txtpalavra.MaxLength = 45;
            this.txtpalavra.Name = "txtpalavra";
            this.txtpalavra.Size = new System.Drawing.Size(293, 26);
            this.txtpalavra.TabIndex = 1;
            this.tip_Dicas.SetToolTip(this.txtpalavra, "Digite a palavra ou conjunto de palavras que identificará está entrada");
            // 
            // textCultura
            // 
            this.textCultura.AutoCompleteCustomSource.AddRange(new string[] {
            "Country",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Côte d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Democratic People\'s Republic of Korea (North Korea)",
            "Democratic Republic of the Cong",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Lao People\'s Democratic Republic (Laos)",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia (Federated States of)",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Republic of Korea (South Korea)",
            "Republic of Moldova",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syrian Arab Republic",
            "Tajikistan",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom of Great Britain and Northern Ireland",
            "United Republic of Tanzania",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.textCultura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textCultura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textCultura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCultura.Location = new System.Drawing.Point(45, 400);
            this.textCultura.Multiline = true;
            this.textCultura.Name = "textCultura";
            this.textCultura.Size = new System.Drawing.Size(385, 120);
            this.textCultura.TabIndex = 18;
            this.tip_Dicas.SetToolTip(this.textCultura, "Informe aqui quais as informações culturais envolvendo este lema");
            // 
            // txtGramatica
            // 
            this.txtGramatica.AutoCompleteCustomSource.AddRange(new string[] {
            "Country",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Côte d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Democratic People\'s Republic of Korea (North Korea)",
            "Democratic Republic of the Cong",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Lao People\'s Democratic Republic (Laos)",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia (Federated States of)",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Republic of Korea (South Korea)",
            "Republic of Moldova",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syrian Arab Republic",
            "Tajikistan",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom of Great Britain and Northern Ireland",
            "United Republic of Tanzania",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.txtGramatica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGramatica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGramatica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGramatica.Location = new System.Drawing.Point(436, 400);
            this.txtGramatica.Multiline = true;
            this.txtGramatica.Name = "txtGramatica";
            this.txtGramatica.Size = new System.Drawing.Size(375, 120);
            this.txtGramatica.TabIndex = 19;
            this.tip_Dicas.SetToolTip(this.txtGramatica, "Informe neste campo se o lema possui alguma característica gramatical especial");
            // 
            // txtDefinicao
            // 
            this.txtDefinicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinicao.Location = new System.Drawing.Point(45, 204);
            this.txtDefinicao.Multiline = true;
            this.txtDefinicao.Name = "txtDefinicao";
            this.txtDefinicao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDefinicao.Size = new System.Drawing.Size(766, 107);
            this.txtDefinicao.TabIndex = 6;
            this.tip_Dicas.SetToolTip(this.txtDefinicao, "Insira aqui alguma explicação que defina o lema");
            // 
            // ComboGenero
            // 
            this.ComboGenero.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Feminino",
            "Neutro",
            "Sem Gênero"});
            this.ComboGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboGenero.FormattingEnabled = true;
            this.ComboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Neutro",
            "Sem Gênero"});
            this.ComboGenero.Location = new System.Drawing.Point(652, 152);
            this.ComboGenero.Name = "ComboGenero";
            this.ComboGenero.Size = new System.Drawing.Size(159, 28);
            this.ComboGenero.TabIndex = 5;
            this.tip_Dicas.SetToolTip(this.ComboGenero, "Indique o gênero do lema");
            // 
            // ComboIdioma
            // 
            this.ComboIdioma.AutoCompleteCustomSource.AddRange(new string[] {
            "Português",
            "Espanhol",
            "Inglês"});
            this.ComboIdioma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboIdioma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ComboIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboIdioma.FormattingEnabled = true;
            this.ComboIdioma.Items.AddRange(new object[] {
            "Português",
            "Espanhol",
            "Inglês"});
            this.ComboIdioma.Location = new System.Drawing.Point(344, 152);
            this.ComboIdioma.Name = "ComboIdioma";
            this.ComboIdioma.Size = new System.Drawing.Size(137, 28);
            this.ComboIdioma.TabIndex = 3;
            this.tip_Dicas.SetToolTip(this.ComboIdioma, "Defina o idioma do lema");
            // 
            // ComboClasseGram
            // 
            this.ComboClasseGram.AutoCompleteCustomSource.AddRange(new string[] {
            "Artigo",
            "Substantivo",
            "Adjetivo",
            "Advérbio",
            "Preposição",
            "Conjunção",
            "Interjeição",
            "Pronome",
            "Verbo",
            "Numeral"});
            this.ComboClasseGram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboClasseGram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboClasseGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboClasseGram.FormattingEnabled = true;
            this.ComboClasseGram.Items.AddRange(new object[] {
            "Artigo",
            "Substantivo",
            "Adjetivo",
            "Advérbio",
            "Preposição",
            "Conjunção",
            "Interjeição",
            "Pronome",
            "Verbo",
            "Numeral"});
            this.ComboClasseGram.Location = new System.Drawing.Point(487, 152);
            this.ComboClasseGram.Name = "ComboClasseGram";
            this.ComboClasseGram.Size = new System.Drawing.Size(159, 28);
            this.ComboClasseGram.TabIndex = 4;
            this.tip_Dicas.SetToolTip(this.ComboClasseGram, "Determine a classe gramatical.\r\nDigite um texto para buscar registros existentes");
            // 
            // label_palavra
            // 
            this.label_palavra.AutoSize = true;
            this.label_palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_palavra.Location = new System.Drawing.Point(42, 131);
            this.label_palavra.Name = "label_palavra";
            this.label_palavra.Size = new System.Drawing.Size(57, 18);
            this.label_palavra.TabIndex = 26;
            this.label_palavra.Text = "Palavra";
            // 
            // label_cult
            // 
            this.label_cult.AutoSize = true;
            this.label_cult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_cult.Location = new System.Drawing.Point(42, 379);
            this.label_cult.Name = "label_cult";
            this.label_cult.Size = new System.Drawing.Size(110, 18);
            this.label_cult.TabIndex = 28;
            this.label_cult.Text = "Notas Culturais";
            // 
            // label_grammar
            // 
            this.label_grammar.AutoSize = true;
            this.label_grammar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_grammar.Location = new System.Drawing.Point(433, 379);
            this.label_grammar.Name = "label_grammar";
            this.label_grammar.Size = new System.Drawing.Size(132, 18);
            this.label_grammar.TabIndex = 29;
            this.label_grammar.Text = "Notas Gramaticais";
            // 
            // label_acep
            // 
            this.label_acep.AutoSize = true;
            this.label_acep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_acep.Location = new System.Drawing.Point(42, 183);
            this.label_acep.Name = "label_acep";
            this.label_acep.Size = new System.Drawing.Size(70, 18);
            this.label_acep.TabIndex = 30;
            this.label_acep.Text = "Definição";
            // 
            // label_catgrama
            // 
            this.label_catgrama.AutoSize = true;
            this.label_catgrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_catgrama.Location = new System.Drawing.Point(484, 131);
            this.label_catgrama.Name = "label_catgrama";
            this.label_catgrama.Size = new System.Drawing.Size(130, 18);
            this.label_catgrama.TabIndex = 34;
            this.label_catgrama.Text = "Classe Gramatical";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblGenero.Location = new System.Drawing.Point(649, 131);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(58, 18);
            this.lblGenero.TabIndex = 38;
            this.lblGenero.Text = "Gênero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(341, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Idioma";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(868, 136);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 30);
            this.btnNovo.TabIndex = 40;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(868, 172);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 33);
            this.btnSalva.TabIndex = 12;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApaga.Location = new System.Drawing.Point(868, 211);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(75, 32);
            this.btnApaga.TabIndex = 44;
            this.btnApaga.Text = "Excluir";
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // menu_barra
            // 
            this.menu_barra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoRápidoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menu_barra.Location = new System.Drawing.Point(0, 0);
            this.menu_barra.Name = "menu_barra";
            this.menu_barra.Size = new System.Drawing.Size(1008, 29);
            this.menu_barra.TabIndex = 46;
            this.menu_barra.Text = "menuStrip1";
            // 
            // acessoRápidoToolStripMenuItem
            // 
            this.acessoRápidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referênciasToolStripMenuItem,
            this.toolStripSeparator1,
            this.importarToolStripMenuItem});
            this.acessoRápidoToolStripMenuItem.Name = "acessoRápidoToolStripMenuItem";
            this.acessoRápidoToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.acessoRápidoToolStripMenuItem.Text = "Acesso Rápido";
            // 
            // referênciasToolStripMenuItem
            // 
            this.referênciasToolStripMenuItem.Name = "referênciasToolStripMenuItem";
            this.referênciasToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.referênciasToolStripMenuItem.Text = "Referências";
            this.referênciasToolStripMenuItem.Click += new System.EventHandler(this.referênciasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.importarToolStripMenuItem.Text = "Importar...";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.contatoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.contatoToolStripMenuItem.Text = "Contato";
            this.contatoToolStripMenuItem.Click += new System.EventHandler(this.contatoToolStripMenuItem_Click);
            // 
            // btnEquiv
            // 
            this.btnEquiv.Enabled = false;
            this.btnEquiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquiv.Location = new System.Drawing.Point(848, 442);
            this.btnEquiv.Name = "btnEquiv";
            this.btnEquiv.Size = new System.Drawing.Size(123, 38);
            this.btnEquiv.TabIndex = 58;
            this.btnEquiv.Text = "Equivalentes";
            this.btnEquiv.UseVisualStyleBackColor = true;
            this.btnEquiv.Click += new System.EventHandler(this.btnEquiv_Click);
            // 
            // btnConjuga
            // 
            this.btnConjuga.Enabled = false;
            this.btnConjuga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConjuga.Location = new System.Drawing.Point(848, 400);
            this.btnConjuga.Name = "btnConjuga";
            this.btnConjuga.Size = new System.Drawing.Size(123, 36);
            this.btnConjuga.TabIndex = 59;
            this.btnConjuga.Text = "Conjugações";
            this.btnConjuga.UseVisualStyleBackColor = true;
            this.btnConjuga.Click += new System.EventHandler(this.btnConjuga_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Enabled = false;
            this.btnPrimeiro.Location = new System.Drawing.Point(868, 283);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeiro.TabIndex = 60;
            this.btnPrimeiro.Text = "|<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(868, 310);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 61;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProx
            // 
            this.btnProx.Enabled = false;
            this.btnProx.Location = new System.Drawing.Point(868, 339);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(75, 23);
            this.btnProx.TabIndex = 62;
            this.btnProx.Text = ">";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Enabled = false;
            this.btnUltimo.Location = new System.Drawing.Point(868, 368);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnUltimo.TabIndex = 63;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboFiltroPrecisao);
            this.groupBox1.Controls.Add(this.comboFiltroIdiomas);
            this.groupBox1.Controls.Add(this.filterComboBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Location = new System.Drawing.Point(45, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 57);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // ComboFiltroPrecisao
            // 
            this.ComboFiltroPrecisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFiltroPrecisao.FormattingEnabled = true;
            this.ComboFiltroPrecisao.Items.AddRange(new object[] {
            "Exatamente",
            "Contém"});
            this.ComboFiltroPrecisao.Location = new System.Drawing.Point(500, 15);
            this.ComboFiltroPrecisao.Name = "ComboFiltroPrecisao";
            this.ComboFiltroPrecisao.Size = new System.Drawing.Size(121, 28);
            this.ComboFiltroPrecisao.TabIndex = 55;
            this.ComboFiltroPrecisao.Text = "Precisão";
            // 
            // comboFiltroIdiomas
            // 
            this.comboFiltroIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFiltroIdiomas.FormattingEnabled = true;
            this.comboFiltroIdiomas.Items.AddRange(new object[] {
            "Qualquer",
            "BR",
            "EN",
            "ES"});
            this.comboFiltroIdiomas.Location = new System.Drawing.Point(221, 15);
            this.comboFiltroIdiomas.Name = "comboFiltroIdiomas";
            this.comboFiltroIdiomas.Size = new System.Drawing.Size(110, 28);
            this.comboFiltroIdiomas.TabIndex = 54;
            this.comboFiltroIdiomas.Text = "Idiomas";
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Lema",
            "Código"});
            this.filterComboBox.Location = new System.Drawing.Point(366, 15);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(110, 28);
            this.filterComboBox.TabIndex = 53;
            this.filterComboBox.Text = "Filtro";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(641, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 28);
            this.searchButton.TabIndex = 52;
            this.searchButton.Text = "Procurar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Country",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Côte d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Democratic People\'s Republic of Korea (North Korea)",
            "Democratic Republic of the Cong",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Lao People\'s Democratic Republic (Laos)",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia (Federated States of)",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Republic of Korea (South Korea)",
            "Republic of Moldova",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syrian Arab Republic",
            "Tajikistan",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom of Great Britain and Northern Ireland",
            "United Republic of Tanzania",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(15, 17);
            this.searchBox.MaxLength = 45;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(179, 26);
            this.searchBox.TabIndex = 51;
            this.searchBox.Text = "Buscar...";
            // 
            // btnFrase
            // 
            this.btnFrase.Enabled = false;
            this.btnFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrase.Location = new System.Drawing.Point(848, 486);
            this.btnFrase.Name = "btnFrase";
            this.btnFrase.Size = new System.Drawing.Size(123, 34);
            this.btnFrase.TabIndex = 65;
            this.btnFrase.Text = "Fraseologia";
            this.btnFrase.UseVisualStyleBackColor = true;
            this.btnFrase.Click += new System.EventHandler(this.btnFrase_Click);
            // 
            // frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 542);
            this.Controls.Add(this.btnFrase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnConjuga);
            this.Controls.Add(this.btnEquiv);
            this.Controls.Add(this.menu_barra);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.label_catgrama);
            this.Controls.Add(this.label_acep);
            this.Controls.Add(this.label_grammar);
            this.Controls.Add(this.label_cult);
            this.Controls.Add(this.label_palavra);
            this.Controls.Add(this.ComboClasseGram);
            this.Controls.Add(this.ComboIdioma);
            this.Controls.Add(this.ComboGenero);
            this.Controls.Add(this.txtDefinicao);
            this.Controls.Add(this.txtGramatica);
            this.Controls.Add(this.textCultura);
            this.Controls.Add(this.txtpalavra);
            this.MainMenuStrip = this.menu_barra;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 580);
            this.Name = "frm_Edit";
            this.Text = "Edição de entradas";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.menu_barra.ResumeLayout(false);
            this.menu_barra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpalavra;
        private System.Windows.Forms.TextBox textCultura;
        private System.Windows.Forms.TextBox txtGramatica;
        private System.Windows.Forms.TextBox txtDefinicao;
        private System.Windows.Forms.ComboBox ComboGenero;
        private System.Windows.Forms.ComboBox ComboIdioma;
        private System.Windows.Forms.ComboBox ComboClasseGram;
        private System.Windows.Forms.Label label_palavra;
        private System.Windows.Forms.Label label_cult;
        private System.Windows.Forms.Label label_grammar;
        private System.Windows.Forms.Label label_acep;
        private System.Windows.Forms.Label label_catgrama;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.MenuStrip menu_barra;
        private System.Windows.Forms.ToolStripMenuItem acessoRápidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
        private System.Windows.Forms.ToolTip tip_Dicas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.Button btnEquiv;
        private System.Windows.Forms.Button btnConjuga;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboFiltroPrecisao;
        private System.Windows.Forms.ComboBox comboFiltroIdiomas;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnFrase;
    }
}
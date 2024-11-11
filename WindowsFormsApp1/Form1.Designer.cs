namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnStrpPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarPáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarComOBingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarPróximaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substituirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irParaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quebraAutomáticaDeLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampliarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarZoomPadrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirAjudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarComentáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreOBlocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sttsStrpInformacoes = new System.Windows.Forms.StatusStrip();
            this.rchTxtBxConteudo = new System.Windows.Forms.RichTextBox();
            this.opnFlDlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.svFlDlgAbrir = new System.Windows.Forms.SaveFileDialog();
            this.pesquisarDiretoNoChatGPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prntDcmntConteudo = new System.Drawing.Printing.PrintDocument();
            this.pgStpDlgConfiguraPagina = new System.Windows.Forms.PageSetupDialog();
            this.prImprimirntDlg = new System.Windows.Forms.PrintDialog();
            this.fntDlgFonte = new System.Windows.Forms.FontDialog();
            this.tlStrpSttsLblCodificacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlStrpSttsLblFormato = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlStrpSttsLblZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlStrpSttsLblPosicionamento = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxPergunta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxResposta = new System.Windows.Forms.RichTextBox();
            this.mnStrpPrincipal.SuspendLayout();
            this.sttsStrpInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnStrpPrincipal
            // 
            this.mnStrpPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mnStrpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnStrpPrincipal.Name = "mnStrpPrincipal";
            this.mnStrpPrincipal.Size = new System.Drawing.Size(1483, 24);
            this.mnStrpPrincipal.TabIndex = 0;
            this.mnStrpPrincipal.Text = "menuStrip1";
            this.mnStrpPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.novaJanelaToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.configurarPáginaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // novaJanelaToolStripMenuItem
            // 
            this.novaJanelaToolStripMenuItem.Name = "novaJanelaToolStripMenuItem";
            this.novaJanelaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.novaJanelaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.novaJanelaToolStripMenuItem.Text = "Nova Janela";
            this.novaJanelaToolStripMenuItem.Click += new System.EventHandler(this.novaJanelaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(219, 6);
            // 
            // configurarPáginaToolStripMenuItem
            // 
            this.configurarPáginaToolStripMenuItem.Name = "configurarPáginaToolStripMenuItem";
            this.configurarPáginaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.configurarPáginaToolStripMenuItem.Text = "Configurar Página...";
            this.configurarPáginaToolStripMenuItem.Click += new System.EventHandler(this.configurarPáginaToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(219, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.toolStripMenuItem3,
            this.recortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.toolStripMenuItem4,
            this.buscarComOBingToolStripMenuItem,
            this.localizarToolStripMenuItem,
            this.localizarPróximaToolStripMenuItem,
            this.localizarAnteriorToolStripMenuItem,
            this.substituirToolStripMenuItem,
            this.irParaToolStripMenuItem,
            this.toolStripMenuItem5,
            this.selecionarTudoToolStripMenuItem,
            this.horadataToolStripMenuItem,
            this.pesquisarDiretoNoChatGPTToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.desfazerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(293, 6);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(293, 6);
            // 
            // buscarComOBingToolStripMenuItem
            // 
            this.buscarComOBingToolStripMenuItem.Name = "buscarComOBingToolStripMenuItem";
            this.buscarComOBingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.buscarComOBingToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.buscarComOBingToolStripMenuItem.Text = "Buscar com o Bing...";
            this.buscarComOBingToolStripMenuItem.Click += new System.EventHandler(this.buscarComOBingToolStripMenuItem_Click);
            // 
            // localizarToolStripMenuItem
            // 
            this.localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
            this.localizarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.localizarToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.localizarToolStripMenuItem.Text = "Localizar...";
            // 
            // localizarPróximaToolStripMenuItem
            // 
            this.localizarPróximaToolStripMenuItem.Name = "localizarPróximaToolStripMenuItem";
            this.localizarPróximaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.localizarPróximaToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.localizarPróximaToolStripMenuItem.Text = "Localizar próxima";
            // 
            // localizarAnteriorToolStripMenuItem
            // 
            this.localizarAnteriorToolStripMenuItem.Name = "localizarAnteriorToolStripMenuItem";
            this.localizarAnteriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.localizarAnteriorToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.localizarAnteriorToolStripMenuItem.Text = "Localizar Anterior";
            // 
            // substituirToolStripMenuItem
            // 
            this.substituirToolStripMenuItem.Name = "substituirToolStripMenuItem";
            this.substituirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.substituirToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.substituirToolStripMenuItem.Text = "Substituir...";
            // 
            // irParaToolStripMenuItem
            // 
            this.irParaToolStripMenuItem.Name = "irParaToolStripMenuItem";
            this.irParaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.irParaToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.irParaToolStripMenuItem.Text = "Ir para...";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(293, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar tudo";
            this.selecionarTudoToolStripMenuItem.Click += new System.EventHandler(this.selecionarTudoToolStripMenuItem_Click);
            // 
            // horadataToolStripMenuItem
            // 
            this.horadataToolStripMenuItem.Name = "horadataToolStripMenuItem";
            this.horadataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.horadataToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.horadataToolStripMenuItem.Text = "Hora/data";
            this.horadataToolStripMenuItem.Click += new System.EventHandler(this.horadataToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quebraAutomáticaDeLinhaToolStripMenuItem,
            this.fonteToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "&Formatar";
            // 
            // quebraAutomáticaDeLinhaToolStripMenuItem
            // 
            this.quebraAutomáticaDeLinhaToolStripMenuItem.Name = "quebraAutomáticaDeLinhaToolStripMenuItem";
            this.quebraAutomáticaDeLinhaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.quebraAutomáticaDeLinhaToolStripMenuItem.Text = "Quebra automática de linha";
            this.quebraAutomáticaDeLinhaToolStripMenuItem.Click += new System.EventHandler(this.quebraAutomáticaDeLinhaToolStripMenuItem_Click);
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.fonteToolStripMenuItem.Text = "Fonte...";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.barraDeStatusToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "E&xibir";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ampliarToolStripMenuItem,
            this.reduzirToolStripMenuItem,
            this.restaurarZoomPadrãoToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // ampliarToolStripMenuItem
            // 
            this.ampliarToolStripMenuItem.Name = "ampliarToolStripMenuItem";
            this.ampliarToolStripMenuItem.ShortcutKeyDisplayString = "Crtl + sinal de adição";
            this.ampliarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.ampliarToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.ampliarToolStripMenuItem.Text = "Ampliar";
            // 
            // reduzirToolStripMenuItem
            // 
            this.reduzirToolStripMenuItem.Name = "reduzirToolStripMenuItem";
            this.reduzirToolStripMenuItem.ShortcutKeyDisplayString = "Crtl + sinal de menos";
            this.reduzirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.reduzirToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.reduzirToolStripMenuItem.Text = "Reduzir";
            // 
            // restaurarZoomPadrãoToolStripMenuItem
            // 
            this.restaurarZoomPadrãoToolStripMenuItem.Name = "restaurarZoomPadrãoToolStripMenuItem";
            this.restaurarZoomPadrãoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.restaurarZoomPadrãoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.restaurarZoomPadrãoToolStripMenuItem.Text = "Restaurar Zoom Padrão";
            // 
            // barraDeStatusToolStripMenuItem
            // 
            this.barraDeStatusToolStripMenuItem.Name = "barraDeStatusToolStripMenuItem";
            this.barraDeStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barraDeStatusToolStripMenuItem.Text = "Barra de status";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirAjudaToolStripMenuItem,
            this.enviarComentáriosToolStripMenuItem,
            this.toolStripMenuItem6,
            this.sobreOBlocoDeNotasToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "A&juda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // exibirAjudaToolStripMenuItem
            // 
            this.exibirAjudaToolStripMenuItem.Name = "exibirAjudaToolStripMenuItem";
            this.exibirAjudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirAjudaToolStripMenuItem.Text = "Exibir Ajuda";
            // 
            // enviarComentáriosToolStripMenuItem
            // 
            this.enviarComentáriosToolStripMenuItem.Name = "enviarComentáriosToolStripMenuItem";
            this.enviarComentáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enviarComentáriosToolStripMenuItem.Text = "Enviar Comentários";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(177, 6);
            // 
            // sobreOBlocoDeNotasToolStripMenuItem
            // 
            this.sobreOBlocoDeNotasToolStripMenuItem.Name = "sobreOBlocoDeNotasToolStripMenuItem";
            this.sobreOBlocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreOBlocoDeNotasToolStripMenuItem.Text = "Sobre o TeskMaster";
            // 
            // sttsStrpInformacoes
            // 
            this.sttsStrpInformacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrpSttsLblCodificacao,
            this.tlStrpSttsLblFormato,
            this.tlStrpSttsLblZoom,
            this.tlStrpSttsLblPosicionamento});
            this.sttsStrpInformacoes.Location = new System.Drawing.Point(0, 561);
            this.sttsStrpInformacoes.Name = "sttsStrpInformacoes";
            this.sttsStrpInformacoes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sttsStrpInformacoes.Size = new System.Drawing.Size(1483, 24);
            this.sttsStrpInformacoes.TabIndex = 1;
            this.sttsStrpInformacoes.Text = "statusStrip1";
            // 
            // rchTxtBxConteudo
            // 
            this.rchTxtBxConteudo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rchTxtBxConteudo.Location = new System.Drawing.Point(0, 27);
            this.rchTxtBxConteudo.Name = "rchTxtBxConteudo";
            this.rchTxtBxConteudo.Size = new System.Drawing.Size(1030, 533);
            this.rchTxtBxConteudo.TabIndex = 2;
            this.rchTxtBxConteudo.Text = "";
            this.rchTxtBxConteudo.TextChanged += new System.EventHandler(this.rchTxtBxConteudo_TextChanged);
            // 
            // opnFlDlgAbrir
            // 
            this.opnFlDlgAbrir.Filter = "Arquivos de texto (*.txt)|*.txt|Documentos de texto (*.rtf)|*.rtf|Todos os arquiv" +
    "os (*.*)|*.*";
            this.opnFlDlgAbrir.InitialDirectory = "C:";
            this.opnFlDlgAbrir.Title = "Abrir Arquivo";
            // 
            // svFlDlgAbrir
            // 
            this.svFlDlgAbrir.Filter = "Arquivos de texto (*.txt)|*.txt|Documentos de texto (*.rtf)|*.rtf|Todos os arquiv" +
    "os (*.*)|*.*";
            this.svFlDlgAbrir.Title = "Salvar Como...";
            // 
            // pesquisarDiretoNoChatGPTToolStripMenuItem
            // 
            this.pesquisarDiretoNoChatGPTToolStripMenuItem.Name = "pesquisarDiretoNoChatGPTToolStripMenuItem";
            this.pesquisarDiretoNoChatGPTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.pesquisarDiretoNoChatGPTToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.pesquisarDiretoNoChatGPTToolStripMenuItem.Text = "Pesquisar direto no chatGPT";
            this.pesquisarDiretoNoChatGPTToolStripMenuItem.Click += new System.EventHandler(this.pesquisarDiretoNoChatGPTToolStripMenuItem_Click);
            // 
            // pgStpDlgConfiguraPagina
            // 
            this.pgStpDlgConfiguraPagina.Document = this.prntDcmntConteudo;
            // 
            // prImprimirntDlg
            // 
            this.prImprimirntDlg.Document = this.prntDcmntConteudo;
            this.prImprimirntDlg.UseEXDialog = true;
            // 
            // fntDlgFonte
            // 
            this.fntDlgFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tlStrpSttsLblCodificacao
            // 
            this.tlStrpSttsLblCodificacao.Name = "tlStrpSttsLblCodificacao";
            this.tlStrpSttsLblCodificacao.Size = new System.Drawing.Size(38, 19);
            this.tlStrpSttsLblCodificacao.Text = "UTF-8";
            // 
            // tlStrpSttsLblFormato
            // 
            this.tlStrpSttsLblFormato.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tlStrpSttsLblFormato.Name = "tlStrpSttsLblFormato";
            this.tlStrpSttsLblFormato.Size = new System.Drawing.Size(103, 19);
            this.tlStrpSttsLblFormato.Text = "Windows (CR-LF)";
            // 
            // tlStrpSttsLblZoom
            // 
            this.tlStrpSttsLblZoom.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tlStrpSttsLblZoom.Name = "tlStrpSttsLblZoom";
            this.tlStrpSttsLblZoom.Size = new System.Drawing.Size(39, 19);
            this.tlStrpSttsLblZoom.Text = "100%";
            // 
            // tlStrpSttsLblPosicionamento
            // 
            this.tlStrpSttsLblPosicionamento.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tlStrpSttsLblPosicionamento.Name = "tlStrpSttsLblPosicionamento";
            this.tlStrpSttsLblPosicionamento.Size = new System.Drawing.Size(57, 19);
            this.tlStrpSttsLblPosicionamento.Text = "Ln: , Col:";
            // 
            // textBoxPergunta
            // 
            this.textBoxPergunta.Location = new System.Drawing.Point(1036, 64);
            this.textBoxPergunta.Multiline = true;
            this.textBoxPergunta.Name = "textBoxPergunta";
            this.textBoxPergunta.Size = new System.Drawing.Size(425, 217);
            this.textBoxPergunta.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1036, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxResposta
            // 
            this.richTextBoxResposta.Location = new System.Drawing.Point(1036, 287);
            this.richTextBoxResposta.Name = "richTextBoxResposta";
            this.richTextBoxResposta.Size = new System.Drawing.Size(425, 271);
            this.richTextBoxResposta.TabIndex = 5;
            this.richTextBoxResposta.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1483, 585);
            this.Controls.Add(this.richTextBoxResposta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPergunta);
            this.Controls.Add(this.rchTxtBxConteudo);
            this.Controls.Add(this.sttsStrpInformacoes);
            this.Controls.Add(this.mnStrpPrincipal);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnStrpPrincipal;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mnStrpPrincipal.ResumeLayout(false);
            this.mnStrpPrincipal.PerformLayout();
            this.sttsStrpInformacoes.ResumeLayout(false);
            this.sttsStrpInformacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnStrpPrincipal;
        private System.Windows.Forms.StatusStrip sttsStrpInformacoes;
        private System.Windows.Forms.RichTextBox rchTxtBxConteudo;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaJanelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configurarPáginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem buscarComOBingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarPróximaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substituirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irParaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quebraAutomáticaDeLinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduzirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarZoomPadrãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDeStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirAjudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarComentáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem sobreOBlocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog opnFlDlgAbrir;
        private System.Windows.Forms.SaveFileDialog svFlDlgAbrir;
        private System.Windows.Forms.ToolStripMenuItem pesquisarDiretoNoChatGPTToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument prntDcmntConteudo;
        private System.Windows.Forms.PageSetupDialog pgStpDlgConfiguraPagina;
        private System.Windows.Forms.PrintDialog prImprimirntDlg;
        private System.Windows.Forms.FontDialog fntDlgFonte;
        private System.Windows.Forms.ToolStripStatusLabel tlStrpSttsLblCodificacao;
        private System.Windows.Forms.ToolStripStatusLabel tlStrpSttsLblFormato;
        private System.Windows.Forms.ToolStripStatusLabel tlStrpSttsLblZoom;
        private System.Windows.Forms.ToolStripStatusLabel tlStrpSttsLblPosicionamento;
        private System.Windows.Forms.TextBox textBoxPergunta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxResposta;
    }
}


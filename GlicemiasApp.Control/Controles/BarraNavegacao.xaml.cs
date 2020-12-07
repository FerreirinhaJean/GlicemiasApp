using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GlicemiasApp.Control.Controles
{
    /// <summary>
    /// Interação lógica para BarraNavegacao.xam
    /// </summary>
    public partial class BarraNavegacao : UserControl
    {

        #region Dependency Properties

        public static readonly DependencyProperty NovoVisibilityProperty =
            DependencyProperty.Register("NovoVisibility", typeof(Visibility), typeof(BarraNavegacao));

        public static readonly DependencyProperty ExcluirVisibilityProperty =
            DependencyProperty.Register("ExcluirVisibility", typeof(Visibility), typeof(BarraNavegacao));

        public static readonly DependencyProperty SalvarVisibilityProperty =
            DependencyProperty.Register("SalvarVisibility", typeof(Visibility), typeof(BarraNavegacao));

        public static readonly DependencyProperty PesquisaVisibilityProperty =
            DependencyProperty.Register("PesquisaVisibility", typeof(Visibility), typeof(BarraNavegacao), new FrameworkPropertyMetadata(Visibility.Collapsed));

        public static readonly DependencyProperty ImprimirVisibilityProperty =
            DependencyProperty.Register("ImprimirVisibility", typeof(Visibility), typeof(BarraNavegacao));

        public static readonly DependencyProperty ImprimirIsEnabledProperty =
            DependencyProperty.Register("ImprimirIsEnabled", typeof(bool), typeof(BarraNavegacao), new FrameworkPropertyMetadata(true));

        #endregion
        #region Propriedades

        public Visibility NovoVisibility
        {
            get { return (Visibility)GetValue(NovoVisibilityProperty); }
            set { SetValue(NovoVisibilityProperty, value); }
        }

        public Visibility SalvarVisibility
        {
            get { return (Visibility)GetValue(SalvarVisibilityProperty); }
            set { SetValue(SalvarVisibilityProperty, value); }
        }

        public Visibility ExcluirVisibility
        {
            get { return (Visibility)GetValue(ExcluirVisibilityProperty); }
            set { SetValue(ExcluirVisibilityProperty, value); }
        }

        public Visibility PesquisaVisibility
        {
            get { return (Visibility)GetValue(PesquisaVisibilityProperty); }
            set { SetValue(PesquisaVisibilityProperty, value); }
        }

        public Visibility ImprimirVisibility
        {
            get { return (Visibility)GetValue(ImprimirVisibilityProperty); }
            set { SetValue(ImprimirVisibilityProperty, value); }
        }

        public bool ImprimirIsEnabled
        {
            get { return (bool)GetValue(ImprimirIsEnabledProperty); }
            set { SetValue(ImprimirIsEnabledProperty, value); }
        }

        public bool ImprimirAlwaysEnabled { get; set; }

        public bool[] Permission { get; set; }

        #endregion Propriedades

        #region Contrutores de Eventos

        #region Novo

        public static readonly RoutedEvent NovoClickEvent =
            EventManager.RegisterRoutedEvent("NovoClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler NovoClick { add { AddHandler(NovoClickEvent, value); } remove { RemoveHandler(NovoClickEvent, value); } }

        private void OnNovoClick()
        {
            RaiseEvent(new RoutedEventArgs(NovoClickEvent, this));
        }

        #endregion Novo

        #region Salvar

        public static readonly RoutedEvent SalvarClickEvent =
            EventManager.RegisterRoutedEvent("SalvarClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler SalvarClick { add { AddHandler(SalvarClickEvent, value); } remove { RemoveHandler(SalvarClickEvent, value); } }

        private void OnSalvarClick()
        {
            RaiseEvent(new RoutedEventArgs(SalvarClickEvent, this));
        }

        #endregion Salvar

        #region Excluir

        public static readonly RoutedEvent ExcluirClickEvent =
            EventManager.RegisterRoutedEvent("ExcluirClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler ExcluirClick { add { AddHandler(ExcluirClickEvent, value); } remove { RemoveHandler(ExcluirClickEvent, value); } }

        private void OnExcluirClick()
        {
            RaiseEvent(new RoutedEventArgs(ExcluirClickEvent, this));
        }

        #endregion Excluir

        #region Limpar

        public static readonly RoutedEvent LimparClickEvent =
            EventManager.RegisterRoutedEvent("LimparClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler LimparClick { add { AddHandler(LimparClickEvent, value); } remove { RemoveHandler(LimparClickEvent, value); } }

        private void OnLimparClick()
        {
            RaiseEvent(new RoutedEventArgs(LimparClickEvent, this));
        }

        #endregion Limpar

        #region Pesquisar

        public static readonly RoutedEvent PesquisarClickEvent =
            EventManager.RegisterRoutedEvent("PesquisarClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler PesquisarClick { add { AddHandler(PesquisarClickEvent, value); } remove { RemoveHandler(PesquisarClickEvent, value); } }

        private void OnPesquisarClick()
        {
            RaiseEvent(new RoutedEventArgs(PesquisarClickEvent, this));
        }

        #endregion Pesquisar

        #region Primeiro

        public static readonly RoutedEvent PrimeiroClickEvent =
            EventManager.RegisterRoutedEvent("PrimeiroClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler PrimeiroClick { add { AddHandler(PrimeiroClickEvent, value); } remove { RemoveHandler(PrimeiroClickEvent, value); } }

        private void OnPrimeiroClick()
        {
            RaiseEvent(new RoutedEventArgs(PrimeiroClickEvent, this));
        }

        #endregion Primeiro

        #region Voltar

        public static readonly RoutedEvent VoltarClickEvent =
            EventManager.RegisterRoutedEvent("VoltarClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler VoltarClick { add { AddHandler(VoltarClickEvent, value); } remove { RemoveHandler(VoltarClickEvent, value); } }

        private void OnVoltarClick()
        {
            RaiseEvent(new RoutedEventArgs(VoltarClickEvent, this));
        }

        #endregion Voltar

        #region Avançar

        public static readonly RoutedEvent AvancarClickEvent =
            EventManager.RegisterRoutedEvent("AvancarClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler AvancarClick { add { AddHandler(AvancarClickEvent, value); } remove { RemoveHandler(AvancarClickEvent, value); } }

        private void OnAvancarClick()
        {
            RaiseEvent(new RoutedEventArgs(AvancarClickEvent, this));
        }

        #endregion Avançar

        #region Último

        public static readonly RoutedEvent UltimoClickEvent =
            EventManager.RegisterRoutedEvent("UltimoClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler UltimoClick { add { AddHandler(UltimoClickEvent, value); } remove { RemoveHandler(UltimoClickEvent, value); } }

        private void OnUltimoClick()
        {
            RaiseEvent(new RoutedEventArgs(UltimoClickEvent, this));
        }

        #endregion Último

        #region Imprimir

        public static readonly RoutedEvent ImprimirClickEvent =
            EventManager.RegisterRoutedEvent("ImprimirClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler ImprimirClick { add { AddHandler(ImprimirClickEvent, value); } remove { RemoveHandler(ImprimirClickEvent, value); } }

        private void OnImprimirClick()
        {
            RaiseEvent(new RoutedEventArgs(ImprimirClickEvent, this));
        }

        #endregion Imprimir

        #region Coringa

        public static readonly RoutedEvent CoringaClickEvent =
            EventManager.RegisterRoutedEvent("CoringaClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler CoringaClick { add { AddHandler(CoringaClickEvent, value); } remove { RemoveHandler(CoringaClickEvent, value); } }

        private void OnCoringaClick()
        {
            RaiseEvent(new RoutedEventArgs(CoringaClickEvent, this));
        }

        #endregion

        #region Coringa 2

        public static readonly RoutedEvent Coringa2ClickEvent =
            EventManager.RegisterRoutedEvent("Coringa2Click", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler Coringa2Click { add { AddHandler(Coringa2ClickEvent, value); } remove { RemoveHandler(Coringa2ClickEvent, value); } }

        private void OnCoringa2Click()
        {
            RaiseEvent(new RoutedEventArgs(Coringa2ClickEvent, this));
        }

        #endregion

        #region Duplicar

        public static readonly RoutedEvent DuplicarClickEvent =
            EventManager.RegisterRoutedEvent("DuplicarClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler DuplicarClick { add { AddHandler(DuplicarClickEvent, value); } remove { RemoveHandler(DuplicarClickEvent, value); } }

        private void OnDuplicarClick()
        {
            RaiseEvent(new RoutedEventArgs(DuplicarClickEvent, this));
        }

        #endregion Duplicar

        #region Sair

        public static readonly RoutedEvent SairClickEvent =
            EventManager.RegisterRoutedEvent("SairClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BarraNavegacao));

        [Category("Behavior")]
        public event RoutedEventHandler SairClick { add { AddHandler(SairClickEvent, value); } remove { RemoveHandler(SairClickEvent, value); } }

        private void OnSairClick()
        {
            RaiseEvent(new RoutedEventArgs(SairClickEvent, this));
        }

        #endregion Sair

        #endregion Contrutores de Eventos

        #region Constructor

        public BarraNavegacao()
        {
            InitializeComponent();

            Permission = new[] { true, true, true, true };
        }

        #endregion Constructor

        #region Métodos

        public void InícioButtons()
        {
            if (!IsLoaded)
                return;

            BtnNovo.IsEnabled = Permission[0]; //true
            BtnLimpar.IsEnabled = false;
            BtnSalvar.IsEnabled = false;
            BtnExcluir.IsEnabled = false; //true
            BtnAvancar.IsEnabled = Permission[1]; //true
            BtnVoltar.IsEnabled = Permission[1]; //true
            PesquisarButton.IsEnabled = Permission[1]; //true
            BtnPrimeiro.IsEnabled = Permission[1]; //true
            BtnAvancar.IsEnabled = Permission[1]; //true
            BtnUltimo.IsEnabled = Permission[1]; //true
            ImprimirIsEnabled = !ImprimirIsEnabled || ImprimirAlwaysEnabled;
        }

        public void NovoChangeButtons()
        {
            BtnNovo.IsEnabled = false;
            BtnSalvar.IsEnabled = Permission[0] || Permission[2]; //true
            BtnLimpar.IsEnabled = true;
            BtnExcluir.IsEnabled = false;
            BtnAvancar.IsEnabled = false;
            PesquisarButton.IsEnabled = false;
            BtnVoltar.IsEnabled = false;
            BtnPrimeiro.IsEnabled = false;
            //BtnAvancar.IsEnabled = false;
            BtnUltimo.IsEnabled = false;
            ImprimirIsEnabled = true; //!ImprimirIsEnabled || ImprimirAlwaysEnabled;
            BtnDuplicar.IsEnabled = false;
        }

        public void PesquisarChangeButtons()
        {
            BtnNovo.IsEnabled = Permission[0]; //true
            BtnLimpar.IsEnabled = false;
            BtnSalvar.IsEnabled = Permission[0] || Permission[2]; //true
            BtnExcluir.IsEnabled = Permission[3]; //true
            BtnAvancar.IsEnabled = Permission[1]; //true
            BtnVoltar.IsEnabled = Permission[1]; //true
            PesquisarButton.IsEnabled = Permission[1]; //true
            BtnPrimeiro.IsEnabled = Permission[1]; //true
            BtnAvancar.IsEnabled = Permission[1]; //true
            BtnUltimo.IsEnabled = Permission[1]; //true
            ImprimirIsEnabled = !ImprimirIsEnabled || ImprimirAlwaysEnabled;
        }

        public void NavegacaoChangeButtons()
        {
            BtnNovo.IsEnabled = Permission[0]; //true
            BtnLimpar.IsEnabled = true;
            BtnSalvar.IsEnabled = Permission[2]; // true
            BtnExcluir.IsEnabled = Permission[3]; //true
            PesquisarButton.IsEnabled = Permission[1]; //true
            ImprimirIsEnabled = true;
            BtnDuplicar.IsEnabled = Permission[0];
        }

        public void LimparChangeButtons()
        {
            BtnNovo.IsEnabled = Permission[0]; //true
            BtnLimpar.IsEnabled = true;
            BtnSalvar.IsEnabled = false;
            BtnExcluir.IsEnabled = false;
            PesquisarButton.IsEnabled = Permission[1]; //true
            ImprimirIsEnabled = ImprimirAlwaysEnabled;
            BtnDuplicar.IsEnabled = false;
        }

        #endregion Métodos

        #region Eventos

        private void BtNovoClick(object sender, RoutedEventArgs e)
        {
            OnNovoClick();
        }

        private void BtSalvarClick(object sender, RoutedEventArgs e)
        {
            OnSalvarClick();
        }

        private void BtExcluirClick(object sender, RoutedEventArgs e)
        {
            OnExcluirClick();
        }

        private void BtPesquisarClick(object sender, RoutedEventArgs e)
        {
            OnPesquisarClick();
        }

        private void BtLimparClick(object sender, RoutedEventArgs e)
        {
            OnLimparClick();
        }

        private void BtSairClick(object sender, RoutedEventArgs e)
        {
            OnSairClick();
        }

        private void BtPrimeiroClick(object sender, RoutedEventArgs e)
        {
            OnPrimeiroClick();
        }

        private void BtVoltarClick(object sender, RoutedEventArgs e)
        {
            OnVoltarClick();
        }

        private void BtAvancarClick(object sender, RoutedEventArgs e)
        {
            OnAvancarClick();
        }

        private void BtImprimirClick(object sender, RoutedEventArgs e)
        {
            OnImprimirClick();
        }

        private void BtUltimoClick(object sender, RoutedEventArgs e)
        {
            OnUltimoClick();
        }

        private void BtDuplicarClick(object sender, RoutedEventArgs e)
        {
            OnDuplicarClick();
        }

        private void BtCoringaClick(object sender, RoutedEventArgs e)
        {
            OnCoringaClick();
        }

        private void BtCoringa2Click(object sender, RoutedEventArgs e)
        {
            OnCoringa2Click();
        }

        #endregion Eventos
    }
}

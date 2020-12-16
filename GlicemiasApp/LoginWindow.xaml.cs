using GlicemiasBaseDados.Model;
using GlicemiasBaseDados.Uteis;
using NHibernate;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace GlicemiasApp
{
    /// <summary>
    /// Lógica interna para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        private IStatelessSession StatelessSession;

        public LoginWindow()
        {
            InitializeComponent();

            Db.GetConnectionDb();

            StatelessSession = Db.SessionFactory.OpenStatelessSession();

        }

        private void BtLogin_Click(object sender, RoutedEventArgs e)
        {
            var usuario = StatelessSession.QueryOver<Usuario>().List();
            Console.WriteLine(usuario[0].Cpf);
        }
    }
}

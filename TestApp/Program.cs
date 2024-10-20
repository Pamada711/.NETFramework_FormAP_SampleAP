using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Domain.Exceptions;
using TestApp.Views;
using static TestApp.Domain.Exceptions.ExceptionBase;


namespace TestApp
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.Run(new ErrorListView());
        }

        private static void Application_ThreadException(
            object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            var exception = e.Exception as ExceptionBase;
            if (exception != null)
            {
                if (exception.Kind == ExceptionKind.Info)
                {
                    MessageBox.Show(e.Exception.Message, "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                if (exception.Kind == ExceptionKind.Warning)
                {
                    MessageBox.Show(e.Exception.Message, "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                if (exception.Kind == ExceptionKind.Error)
                {
                    MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }
    }
}

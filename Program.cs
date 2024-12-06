namespace Almacén_Virtual_Proyect
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicializa la configuración de la aplicación.
            ApplicationConfiguration.Initialize();

            // Crea una instancia de Form2 (Inicio de sesión).
            Form2 loginForm = new Form2();

            // Muestra el formulario de inicio de sesión como un cuadro de diálogo.
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Si el inicio de sesión es exitoso, abre Form1.
                Application.Run(new Form1());
            }
            else
            {
                // Si el inicio de sesión falla o se cancela, cierra la aplicación.
                Application.Exit();
            }
        }
    }
}
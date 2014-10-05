Namespace My


    Partial Friend Class MyApplication
        Dim StartupManager As New DataManager

        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            StartupManager.Startup()
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            StartupManager.UnhandledException(e)
        End Sub
    End Class


End Namespace


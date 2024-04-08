Imports System.Web.Mvc

Namespace Controllers
    Public Class homeController
        Inherits Controller

        ' GET: home
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace
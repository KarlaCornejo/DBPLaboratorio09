<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auxiliar.aspx.cs" Inherits="AplicacionWebParaDBP.Auxiliar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData["Title"] - MiPrimeraAPI</title>
    <!-- Referencias a Bootstrap y otros estilos -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous" />
    <link rel="stylesheet" href="site.css" asp-append-version="true" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons" />
    <script src="site.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<body>
    <form id="miFormulario" runat="server">
        <asp:ScriptManager runat="server" EnablePageMethods="true"></asp:ScriptManager>
        <header>
            <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3">
                <div class="container-fluid">
                    <a class="navbar-brand" href="WebForm1.aspx">MiPrimeraAPI</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" aria-controls="navbarSupportedContent"
                        aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="navbar-collapse collapse d-sm-inline-flex justify-content-between">
                        <ul class="navbar-nav flex-grow-1">
                            <li class="nav-item">
                                <a class="nav-link text-dark" href="WebForm1.aspx">Home</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link text-dark" href="Privacy.aspx">Privacy</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </header>

        <div class="container">
            <h2>Registro de Alumno</h2>
            <h3>Mostrar desde Sesiones</h3>
            <!-- Espacios para mostrar la información de sesión -->
            <div>
                <strong>Nombre:</strong>
                <asp:Label ID="lblNombre" runat="server" CssClass="text-info"></asp:Label>
            </div>
            <div>
                <strong>Apellidos:</strong>
                <asp:Label ID="lblApellidos" runat="server" CssClass="text-info"></asp:Label>
            </div>
            <div>
                <strong>Sexo:</strong>
                <asp:Label ID="lblSexo" runat="server" CssClass="text-info"></asp:Label>
            </div>
            <div>
                <strong>Direccion:</strong>
                <asp:Label ID="lblDireccion" runat="server" CssClass="text-info"></asp:Label>
            </div>
            <div>
                <strong>Ciudad:</strong>
                <asp:Label ID="lblCiudad" runat="server" CssClass="text-info"></asp:Label>
            </div>

        </div>
        <div class="container">
            <h2>Registro de Alumno</h2>
            <h3>Mostrar desde la Cookies</h3>
            <!-- Agregar el botón para mostrar las cookies -->
            <div>
                <asp:Button ID="btnMostrarCookies" runat="server" Text="Mostrar Cookies" OnClick="btnMostrarCookies_Click" CssClass="btn btn-primary" />
            </div>
            <!-- Espacios para mostrar la información de sesión -->
            <div>
                <strong>Nombre:</strong>
                <asp:Label ID="Label1" runat="server" CssClass="text-info"></asp:Label>
            </div>
            <div>
                <strong>Apellidos:</strong>
                <asp:Label ID="Label2" runat="server" CssClass="text-info"></asp:Label>
            </div>
            <div>
                <strong>Sexo:</strong>
                <asp:Label ID="Label3" runat="server" CssClass="text-info"></asp:Label>
            </div>
            <div>
                <strong>Direccion:</strong>
                <asp:Label ID="Label4" runat="server" CssClass="text-info"></asp:Label>
            </div>
            <div>
                <strong>Ciudad:</strong>
                <asp:Label ID="Label5" runat="server" CssClass="text-info"></asp:Label>
            </div>

        </div>
        <div class="container">
            <div class="row mt-3">
                <div class="cols-sm-2">
                    <asp:Button ID="btnObtenerInformacion" runat="server" Text="Obtener Información" OnClientClick="obtenerInformacion(); return false;" />

                </div>
            </div>
            <div class="row">
                <div class="form-group row mt-3">
                    <div class="col-sm-9">
                        <div class="form-floating row mt-3">
                            <asp:TextBox ID="TextBoxAjax" runat="server" class="form-control" Style="visibility: hidden"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>





        <footer class="border-top footer text-muted">
            <div class="container">
                &copy; 2023 - MiPrimeraAPI - <a href="Privacy.aspx">Privacy</a>
            </div>
        </footer>
    </form>
    <!-- Agregar la función JavaScript para realizar la llamada AJAX -->
    <script type="text/javascript">
        function obtenerInformacion() {
            var valor = "Hola desde el cliente AJAX"; // Puedes cambiar este valor según tus necesidades

            // Llamada AJAX utilizando PageMethods
            PageMethods.getInformacion(valor, OnObtenerInformacionComplete);
        }

        function OnObtenerInformacionComplete(resultado) {
            // Maneja el resultado recibido del servidor
            alert(resultado);
        }
    </script>
</body>
</html>

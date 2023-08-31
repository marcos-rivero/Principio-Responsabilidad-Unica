// See https://aka.ms/new-console-template for more information
using PrincipioResponsabilidadUnica;

Console.WriteLine("Hello, World!");
Articulo articulo = new Articulo();
articulo.GuardarArticulo("Titulo del Articulo", "Contenido del articulo");
var contenido = articulo.ConsultarArticulo("Titulo del Articulo");
Console.WriteLine(contenido);

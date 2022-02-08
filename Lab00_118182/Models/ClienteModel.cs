using Lab00_118182.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab00_118182.Models
{
    public class ClienteModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Es necesario un nombre.")]
        [MaxLength(15)]
        [MinLength(1)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Es necesario un apellido.")]
        [MaxLength(15)]
        [MinLength(1)]
        public string Apellido { get; set; }
        [MinLength(8,ErrorMessage = "El número de celular debe tener 8 dígitos.")]
        [MaxLength(8, ErrorMessage = "El número de celular debe tener 8 dígitos.")]
        public int Telefono { get; set; }
        [MaxLength(500, ErrorMessage = "La descripción no puede ser muy larga.")]
        public string Descripcion { get; set; }

        public static void Guardar(ClienteModel nuevoCliente)
        {
            ClienteData.Instancia.ListaCliente.Add(nuevoCliente);
        }

        public static bool Editar(int id, ClienteModel nuevoCliente)
        {
            try
            {
                var posicion = ClienteData.Instancia.ListaCliente.FindIndex(cliente => cliente.ID == id);
                ClienteData.Instancia.ListaCliente[posicion] = new ClienteModel
                {
                    ID = id,
                    Nombre = nuevoCliente.Nombre,
                    Apellido = nuevoCliente.Apellido,
                    Telefono = nuevoCliente.Telefono,
                    Descripcion = nuevoCliente.Descripcion
                };
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Borrar(int id)
        {
            try
            {
                var posicion = ClienteData.Instancia.ListaCliente.FindIndex(cliente => cliente.ID == id);
                ClienteData.Instancia.ListaCliente.RemoveAt(posicion);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Orden ascendente si la variable tipo es verdadera, orden descendente si es falsa
        public static bool OrdenarNombre(bool tipo)
        {
            try
            {
                if (tipo)
                {
                    for (int i = 0; i < ClienteData.Instancia.ListaCliente.Count; i++)
                    {
                        for (int j = 0; j < ClienteData.Instancia.ListaCliente.Count - 1 - i; j++)
                        {
                            int n = ClienteData.Instancia.ListaCliente[j].Nombre.CompareTo(ClienteData.Instancia.ListaCliente[j + 1].Nombre);
                            if (n > 0)
                            {
                                var Aux = ClienteData.Instancia.ListaCliente[j + 1];
                                ClienteData.Instancia.ListaCliente[j + 1] = ClienteData.Instancia.ListaCliente[j];
                                ClienteData.Instancia.ListaCliente[j] = Aux;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < ClienteData.Instancia.ListaCliente.Count; i++)
                    {
                        for (int j = 0; j < ClienteData.Instancia.ListaCliente.Count - 1 - i; j++)
                        {
                            int n = ClienteData.Instancia.ListaCliente[j].Nombre.CompareTo(ClienteData.Instancia.ListaCliente[j + 1].Nombre);
                            if (n < 0)
                            {
                                var Aux = ClienteData.Instancia.ListaCliente[j + 1];
                                ClienteData.Instancia.ListaCliente[j + 1] = ClienteData.Instancia.ListaCliente[j];
                                ClienteData.Instancia.ListaCliente[j] = Aux;
                            }
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Orden ascendente si la variable tipo es verdadera, orden descendente si es falsa
        public static bool OrdenarApellido(bool tipo)
        {
            try
            {
                if (tipo)
                {
                    for (int i = 0; i < ClienteData.Instancia.ListaCliente.Count; i++)
                    {
                        for (int j = 0; j < ClienteData.Instancia.ListaCliente.Count - 1 - i; j++)
                        {
                            int n = ClienteData.Instancia.ListaCliente[j].Apellido.CompareTo(ClienteData.Instancia.ListaCliente[j + 1].Apellido);
                            if (n > 0)
                            {
                                var Aux = ClienteData.Instancia.ListaCliente[j + 1];
                                ClienteData.Instancia.ListaCliente[j + 1] = ClienteData.Instancia.ListaCliente[j];
                                ClienteData.Instancia.ListaCliente[j] = Aux;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < ClienteData.Instancia.ListaCliente.Count; i++)
                    {
                        for (int j = 0; j < ClienteData.Instancia.ListaCliente.Count - 1 - i; j++)
                        {
                            int n = ClienteData.Instancia.ListaCliente[j].Apellido.CompareTo(ClienteData.Instancia.ListaCliente[j + 1].Apellido);
                            if (n < 0)
                            {
                                var Aux = ClienteData.Instancia.ListaCliente[j + 1];
                                ClienteData.Instancia.ListaCliente[j + 1] = ClienteData.Instancia.ListaCliente[j];
                                ClienteData.Instancia.ListaCliente[j] = Aux;
                            }
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

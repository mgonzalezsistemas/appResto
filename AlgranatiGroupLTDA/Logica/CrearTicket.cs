using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using AlgranatiGroupLTDA.Logica;
using System.IO;

namespace ImprimirTicket
{
    public class CrearTicket
    {
        StringBuilder linea = new StringBuilder();

        int maxCaracteres = 40, cortar; //maximo de caracteres por linea que imprime, depende de cada impresora

        public string LineasGuion() //Metodo para dibujar linea de giones
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCaracteres; i++)
            {
                lineasGuion += "-";
            }
            return linea.AppendLine(lineasGuion).ToString();
        }

        public string LineasAsteriscos() //Metodo para dibujar linea de asteriscos
        {
            string lineasAst = "";
            for (int i = 0; i < maxCaracteres; i++)
            {
                lineasAst += "*";
            }
            return linea.AppendLine(lineasAst).ToString();
        }

        public string LineasIgual() //Metodo para dibujar linea de asteriscos
        {
            string lineasigual = "";
            for (int i = 0; i < maxCaracteres; i++)
            {
                lineasigual += "=";
            }
            return linea.AppendLine(lineasigual).ToString();
        }

        public void EcabezadoPlatos() //Encabezado de los Platos 
        {
            linea.AppendLine("PLATO                         | PRECIO |");
        }

        public void TextoIzquierda(string texto) // Metodo para colocar texto alineado a la izquierda
        {
            if (texto.Length > maxCaracteres)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCaracteres; longitudTexto -= maxCaracteres)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCaracteres));
                    caracterActual += maxCaracteres;
                }
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                linea.AppendLine(texto);
            }
        }

        public void TextoDerecha(string texto)
        {
            if (texto.Length > maxCaracteres)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCaracteres; longitudTexto -= maxCaracteres)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCaracteres));
                    caracterActual += maxCaracteres;
                }
                string espacios = "";
                for (int i = 0; i < (maxCaracteres - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                for (int i = 0; i < (maxCaracteres - texto.Length); i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto);
            }
        } //Metodo para colocar texto alineado a la derecha

        public void TextoCentro(string texto)
        {
            if (texto.Length > maxCaracteres)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCaracteres; longitudTexto -= maxCaracteres)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCaracteres));
                    caracterActual += maxCaracteres;
                }
                string espacios = "";
                int centrar = (maxCaracteres - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;

                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                int centrar = (maxCaracteres - texto.Length) / 2;

                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto);
            }
        } //Metodo para colocar texto alineado al centro

        public void TextoExtremos(string textoIzquyierda, string textoDerecha)
        {
            string textoIzq, textoDer, textoCompleto = "", espacios = "";

            if (textoIzquyierda.Length > 18)
            {
                cortar = textoIzquyierda.Length - 18;
                textoIzq = textoIzquyierda.Remove(18, cortar);
            }
            else
            {
                textoIzq = textoIzquyierda;
            }

            textoCompleto = textoIzq;

            if (textoDerecha.Length > 20)
            {
                cortar = textoDerecha.Length - 20;
                textoDer = textoDerecha.Remove(20, cortar);
            }
            else
            {
                textoDer = textoDerecha;
            }

            int numEspacios = maxCaracteres - (textoIzq.Length + textoDer.Length);
            for (int i = 0; i < numEspacios; i++)
            {
                espacios += " ";
            }
            textoCompleto += espacios + textoDerecha;
            linea.AppendLine(textoCompleto);
        } //Metodo para colocar texto de extremo a extremo

        public void ColocarTotales(string texto, double total)
        {
            string resumen, valor, textoCompleto, espacios = "";

            if (texto.Length > 25)
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25 - cortar);
            }
            else
            {
                resumen = texto;
            }
            textoCompleto = resumen;
            valor = total.ToString("#,#.00");

            int numEspacios = maxCaracteres - (resumen.Length + valor.Length);

            for (int i = 0; i < numEspacios; i++)
            {
                espacios += " ";
            }

            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);
        } //Metodo para colocar los totales

        public void AgregarPlato(string nombre, int cant, double precio, decimal importe)
        {
            if (precio.ToString().Length <= 10)
            {
                string elemento = "", espacios = "";
                bool bandera = false;
                int numEspacion = 0;

                if (nombre.Length > 30)
                {
                    //Cantidad a la derecha
                    //numEspacion = (8 - cant.ToString().Length);
                    //espacios = "";
                    //for (int i = 0; i < numEspacion; i++)
                    //{
                    //    espacios += " ";
                    //}
                    //elemento += espacios + cant.ToString();

                    //precio a la derecha
                    numEspacion = 10 - precio.ToString().Length;
                    espacios = "";
                    for (int i = 0; i < numEspacion; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();

                    //importe a la derecha
                    //numEspacion = 8 - importe.ToString().Length;
                    //espacios = "";
                    //for (int i = 0; i < numEspacion; i++)
                    //{
                    //    espacios += " ";
                    //}
                    //elemento += espacios + importe.ToString();

                    int caracterActual = 0;

                    //Por cada 20 caracteres se crea una nueva linea
                    for (int longitudTexto = nombre.Length; longitudTexto > 30; longitudTexto -= 30)
                    {
                        if (bandera == false)
                        {
                            linea.AppendLine(nombre.Substring(caracterActual, 30) + elemento);
                        }
                        else
                        {
                            linea.AppendLine(nombre.Substring(caracterActual, 30));
                        }
                        caracterActual += 30;
                    }

                    linea.AppendLine(nombre.Substring(caracterActual, nombre.Length - caracterActual));
                }
                else
                {
                    for (int i = 0; i < (30 - nombre.Length); i++)
                    {
                        espacios += " ";
                    }

                    elemento = nombre + espacios;

                    //Cantidad a la derecha
                    //numEspacion = (8 - cant.ToString().Length);
                    //espacios = "";
                    //for (int i = 0; i < numEspacion; i++)
                    //{
                    //    espacios += " ";
                    //}
                    //elemento += espacios + cant.ToString();

                    //precio a la derecha
                    numEspacion = 10 - precio.ToString().Length;
                    espacios = "";
                    for (int i = 0; i < numEspacion; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();

                    //importe a la derecha
                    //numEspacion = 8 - importe.ToString().Length;
                    //espacios = "";
                    //for (int i = 0; i < numEspacion; i++)
                    //{
                    //    espacios += " ";
                    //}
                    //elemento += espacios + importe.ToString();

                    linea.AppendLine(elemento);
                }
            }
            else
            {
                linea.AppendLine("Los valores ingresados para esta fila");
                linea.AppendLine("superan las columnas soportadas por este.");
                throw new Exception("Los valores ingresados para algunas filas del ticket\nsuperan las columnas soportadas por este.");
            }
        } //Metodo para agregar plato al ticket

        public void CortarTicket() //Metodo para cortar el ticket
        {
            linea.AppendLine("\x1b" + "m");
            linea.AppendLine("\x1b" + "d" + "\x09");
        }

        public void AbrirCajon() //Metodo para abrir el cajon, depende de cada impresora
        {
            linea.AppendLine("\x1b" + "p" + "\x00"+"\x0F"+"\x96");
            //linea.AppendLine("\x1b" + "p" + "\x01" + "\x0F" + "\x96");
        }

        public void ImprimirTicket(string impresora) //Metodo para mandar a imprimir el ticket
        {
            //hay que copiar la clase RawPrinterHelper que nos proporciona Microsoft
            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString());
            string nombreArchivo = "C:\\Users\\german\\Desktop\\AlgranatiGroupLTDA\\Tickets\\" + Persistencia.numeroTicket+".txt";
            StreamWriter contenido = new StreamWriter(nombreArchivo);
            contenido.Write(linea);
            contenido.Close();
            linea.Clear();
        }

    }

    //Clase que nos proporciona Mickosoft para imprimir en texto plano
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)] public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)] public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)] public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = Persistencia.numeroTicket.ToString();
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }

}

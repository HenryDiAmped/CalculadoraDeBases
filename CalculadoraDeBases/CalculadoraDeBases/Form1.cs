using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeBases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Método para incluir un nuevo número o letra al textbox de resultado, referente al número a convertir a otra base*/
        private void agregarNumero(string numero)
        {
            /*Si el textbox del numero a convertir es cero, se quita el cero y se agrega el núevo valor*/
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            /*Si no hay cero y se encuentra otro valor, simplemente se va agregando los nuevos dígitos*/
            txtResultado.Text += numero;
        }

        /*Método para convertir la parte entera de un número de baseN a base10*/
        private double DevolverParteEntera(string parteEntera, int baseN)
        {
            /*Se declara las variables: suma (alamacenará la suma acumulada, para hallar la parte entera del número convertido)
              a (será cada sumando que se irá aumentando a la variable suma)*/
            double suma = 0, a = 0;

            /*Se crea un bucle, porque acá empieza la acción repetitiva del proceso de conversión
              i (se inicializa en la primera posicion del string)*/
            for (int i = 0; i < parteEntera.Length; i++)
            {
                /*Solo en los casos en que un dígito de la parte entera sea una letra de la A a la F, se procede a reemplazar la letra por su número equivalente*/
                if (parteEntera[i] == 'A' || parteEntera[i] == 'B' || parteEntera[i] == 'C' || parteEntera[i] == 'D' || parteEntera[i] == 'E' || parteEntera[i] == 'F')
                {
                    /*Con un switch se evalua cada uno de estos casos, se hace el procedimiento con el número que corresponde a cada letra,
                      y se procede a multiplicar por la base del número, elevado al exponente que le toca
                      El exponente se halla restandole a la cantidad de digitos de la parte entera una cantidad (al i se le agrega una unidad y este
                      restará a la cantidad de digitos de la parte entera)*/
                    switch (parteEntera[i])
                    {
                        case 'A': a = 10 * (Math.Pow(baseN, parteEntera.Length - (i + 1))); break;
                        case 'B': a = 11 * (Math.Pow(baseN, parteEntera.Length - (i + 1))); break;
                        case 'C': a = 12 * (Math.Pow(baseN, parteEntera.Length - (i + 1))); break;
                        case 'D': a = 13 * (Math.Pow(baseN, parteEntera.Length - (i + 1))); break;
                        case 'E': a = 14 * (Math.Pow(baseN, parteEntera.Length - (i + 1))); break;
                        case 'F': a = 15 * (Math.Pow(baseN, parteEntera.Length - (i + 1))); break;
                    }
                }
                /*Caso contrario, el dígito al ser un string se hace la conversión a entero, y se procede a multiplicar por la base del número,
                  elevado al exponente que le toca*/
                else
                    a = int.Parse(parteEntera.Substring(i, 1)) * (Math.Pow(baseN, parteEntera.Length - (i + 1)));

                /*la variable suma, va acumulando la suma, para dar el resultado*/
                suma += a;
            }
            /*se retorna el valor de la suma, que es la parte entera del número en baseN convertida a base10*/
            return suma;
        }

        /*Método para convertir la parte decimal de un número de baseN a base10*/
        private double DevolverParteDecimal(string parteDecimal, int baseN)
        {
            /*Se declara las variables: suma (alamacenará la suma acumulada, para hallar la parte decimal del número convertido)
              a (será cada sumando que se irá aumentando a la variable suma)*/
            double suma = 0, a = 0;

            /*Se crea un bucle, porque acá empieza la acción repetitiva del proceso de conversión
              i (se inicializa en la última posicion del string)*/
            for (int i = parteDecimal.Length - 1; i >= 0; i--)
            {
                /*Solo en los casos en que un dígito de la parte decimal sea una letra de la A a la F, se procede a reemplazar la letra por su número equivalente*/
                if (parteDecimal[i] == 'A' || parteDecimal[i] == 'B' || parteDecimal[i] == 'C' || parteDecimal[i] == 'D' || parteDecimal[i] == 'E' || parteDecimal[i] == 'F')
                {
                    /*Con un switch se evalua cada uno de estos casos, se hace el procedimiento con el número que corresponde a cada letra,
                      y se procede a multiplicar por la base del número, elevado al exponente que le toca 
                      El exponente se halla con i (se le agrega la unidad que se le habia quitado y se le cambia de signo)*/
                    switch (parteDecimal[i])
                    {
                        case 'A': a = 10 * (Math.Pow(baseN, -(i + 1))); break;
                        case 'B': a = 11 * (Math.Pow(baseN, -(i + 1))); break;
                        case 'C': a = 12 * (Math.Pow(baseN, -(i + 1))); break;
                        case 'D': a = 13 * (Math.Pow(baseN, -(i + 1))); break;
                        case 'E': a = 14 * (Math.Pow(baseN, -(i + 1))); break;
                        case 'F': a = 15 * (Math.Pow(baseN, -(i + 1))); break;
                    }
                }
                /*Caso contrario, el dígito al ser un string se hace la conversión a entero, y se procede a multiplicar por la base del número,
                  elevado al exponente que le toca*/
                else
                    a = int.Parse(parteDecimal.Substring(i, 1)) * (Math.Pow(baseN, -(i + 1)));

                /*la variable suma, va acumulando la suma, para dar el resultado*/
                suma += a;
            }
            /*se retorna el valor de la suma, que es la parte decimal del número en baseN convertida a base10*/
            return suma;
        }

        /*Método para convertir la parte entera de un número de base10 a baseN*/
        private string DevolverParteEntera1(int num, int baseN)
        {
            /*Se declara la variable rpta (será el resultado la parte entera en base10 converitido a baseN)*/
            string rpta = "";

            /*Se declara una lista que almacenará cada dígito de la parte entera convertida a baseN*/
            List<int> cifrasNumOtraBaseEntera = new List<int>();

            /*Se declara las variables cociente y residuo*/
            int cociente = 0, residuo = 0;

            /*Con un bucle Do-While (se usa Do-While, ya que tiene que hacer le proceso al menos una vez),
              se inicia el proceso de conversión de la parte entera en base10 a baseN*/
            do
            {
                /*Se halla el primer residuo que formará parte de la lista*/
                residuo = num % baseN;

                /*Se halla el primer cociente*/
                cociente = num / baseN;

                /*El valor del num pasa a ser el del cociente anterior*/
                num = cociente;

                /*Se agrega el dígito a la lista*/
                cifrasNumOtraBaseEntera.Add(residuo);

                /*Cuando el cociente sea menor que que la baseN (divisor), se agrega el último digito a la lista*/
                if (cociente < baseN)
                    cifrasNumOtraBaseEntera.Add(cociente);
            } while (cociente >= baseN); /*El bucle continua mientras el cociente aún no es menor que la baseN (divisor)*/

            /*Se inicia bucle para agregar el valor de la conversion a la variable rpta*/
            for (int j = cifrasNumOtraBaseEntera.Count - 1; j >= 0; j--)
            {
                /*Condicional que ayuda a que si la primera cifra del número convertido es 0, no se agregará a la variable rpta*/
                if (j == cifrasNumOtraBaseEntera.Count - 1 && cifrasNumOtraBaseEntera[cifrasNumOtraBaseEntera.Count - 1] == 0)
                    continue;

                /*Si el digito es menor que diez, lo agrega a la variable rpta*/
                if (cifrasNumOtraBaseEntera[j] < 10)
                    rpta += cifrasNumOtraBaseEntera[j];

                /*Si por el contrario, se trata de un número mayor o igual que 10, se agrega su letra correspondiente*/
                else
                {
                    switch (cifrasNumOtraBaseEntera[j])
                    {
                        case 10: rpta += "A"; break;
                        case 11: rpta += "B"; break;
                        case 12: rpta += "C"; break;
                        case 13: rpta += "D"; break;
                        case 14: rpta += "E"; break;
                        case 15: rpta += "F"; break;
                    }
                }
            }
            /*Se retorna el valor de la variable rpta, que es la parte entera convertida de base10 a baseN*/
            return rpta;
        }

        /*Método para convertir la parte decimal de un número de base10 a baseN*/
        private string DevolverParteDecimal1(double num, int baseN)
        {
            /*Se declara la variable rpta (conteniendo un punto decimal) a esta variable se le agregara toda la parte decimal
              convertida a baseN*/
            string rpta = ".";

            /*Se declara una lista que almacenará cada dígito de la parte decimal convertida a baseN*/
            List<int> cifrasNumOtraBaseDecimal = new List<int>();

            /*Se declara una variable numParteDecimal de tipo double, la cual tendra el valor de la parte decimal 
              del numero a convertir (Ejemplo: 4.52 - 4 = 0.52)*/
            double numParteDecimal = num - (int)num;

            /*Se inicia un bucle for, el cual empezará el proceso para la conversión de la parte decimal a baseN*/
            for (int i = 0; i < 3; i++)
            {
                /*la variable numParteDecimal se le multiplica la baseN (base a la que va aconvertir) y se almacena
                  en ella misma*/
                numParteDecimal = numParteDecimal * baseN;

                /*Se añade a la lista de digitos solo la parte entera de numParteDecimal
                  (Ejemplo: 1.56 solo se toma 1)*/
                cifrasNumOtraBaseDecimal.Add((int)numParteDecimal);

                /*A numParteDecimal se le quita la parte entera (Ejemplo: 1.56 - 1 = 0.56)*/
                numParteDecimal = numParteDecimal - (int)numParteDecimal;
            }

            /*Con el ciclo for, se irá agregando los digitos a la variable rpta (este tendrá el valor de la parte decimal convertido)*/
            for (int j = 0; j < cifrasNumOtraBaseDecimal.Count; j++)
            {
                /*Si el digito es menor a diez se agrega de manera normal a la rpta*/
                if (cifrasNumOtraBaseDecimal[j] < 10)
                    rpta += cifrasNumOtraBaseDecimal[j];

                /*Caso contrario, se agrega su letra equivalente*/
                else
                {
                    switch (cifrasNumOtraBaseDecimal[j])
                    {
                        case 10: rpta += "A"; break;
                        case 11: rpta += "B"; break;
                        case 12: rpta += "C"; break;
                        case 13: rpta += "D"; break;
                        case 14: rpta += "E"; break;
                        case 15: rpta += "F"; break;
                    }
                }
            }
            /*Si los tres posiciones de la variable rpta son cero, se retirarán esos ceros y rpta quedara sin punto decimal*/
            if (rpta[1] == '0' && rpta[2] == '0' && rpta[3] == '0')
                rpta = "";

            /*Se retorna el valor de rpta (que es la parte decimal convertida a baseN)*/
            return rpta;
        }


        /*Evento click del boton 1 (Usa el método agregarNumero)*/
        private void btn1_Click_1(object sender, EventArgs e)
        {
            agregarNumero("1");
        }

        /*Evento click del boton 2 (Usa el método agregarNumero)*/
        private void btn2_Click(object sender, EventArgs e)
        {
            agregarNumero("2");
        }

        /*Evento click del boton 3 (Usa el método agregarNumero)*/
        private void btn3_Click(object sender, EventArgs e)
        {
            agregarNumero("3");
        }

        /*Evento click del boton 4 (Usa el método agregarNumero)*/
        private void btn4_Click(object sender, EventArgs e)
        {
            agregarNumero("4");
        }

        /*Evento click del boton 5 (Usa el método agregarNumero)*/
        private void btn5_Click(object sender, EventArgs e)
        {
            agregarNumero("5");
        }

        /*Evento click del boton 6 (Usa el método agregarNumero)*/
        private void btn6_Click(object sender, EventArgs e)
        {
            agregarNumero("6");
        }

        /*Evento click del boton 7 (Usa el método agregarNumero)*/
        private void btn7_Click(object sender, EventArgs e)
        {
            agregarNumero("7");
        }

        /*Evento click del boton 8 (Usa el método agregarNumero)*/
        private void btn8_Click(object sender, EventArgs e)
        {
            agregarNumero("8");
        }

        /*Evento click del boton 9 (Usa el método agregarNumero)*/
        private void btn9_Click(object sender, EventArgs e)
        {
            agregarNumero("9");
        }

        /*Evento click del boton 0 (Usa el método agregarNumero)*/
        private void btn0_Click(object sender, EventArgs e)
        {
            agregarNumero("0");
        }

        /*Evento click del boton Punto (Usa el método agregarNumero)*/
        private void btnPunto_Click(object sender, EventArgs e)
        {
            /*Si la caja de resultado con el número a convertir contiene un 0, se agrega el punto decimal*/
            if (txtResultado.Text == "0")
                txtResultado.Text = "0.";

            /*Se declara variable booleana, que servirá para saber si la caja de resultado
              contiene ya una punto decimal en el número a convertir*/
            bool punto = false;

            /*Con el bucle foreach se recorre todo el número a convertir*/
            foreach (char elem in txtResultado.Text)
            {
                /*Si se encuentra el punto decimal, la variable booleana punto se vuelve verdadera, por lo cual
                  ya no será agregado un nuevo punto*/
                if (elem == '.')
                    punto = true;
            }

            /*Si la variable booleana punto es verdadero, no se agrega nada a la caja de resultado*/
            if (punto)
                agregarNumero("");

            /*Caso contrario, se procede a agregar el punto decimal*/
            else
                agregarNumero(".");
        }

        /*Evento click del boton A (Usa el método agregarNumero)*/
        private void btnA_Click(object sender, EventArgs e)
        {
            agregarNumero("A");
        }

        /*Evento click del boton B (Usa el método agregarNumero)*/
        private void btnB_Click(object sender, EventArgs e)
        {
            agregarNumero("B");
        }

        /*Evento click del boton C (Usa el método agregarNumero)*/
        private void btnC_Click(object sender, EventArgs e)
        {
            agregarNumero("C");
        }

        /*Evento click del boton D (Usa el método agregarNumero)*/
        private void btnD_Click(object sender, EventArgs e)
        {
            agregarNumero("D");
        }

        /*Evento click del boton E (Usa el método agregarNumero)*/
        private void btnE_Click(object sender, EventArgs e)
        {
            agregarNumero("E");
        }

        /*Evento click del boton F (Usa el método agregarNumero)*/
        private void btnF_Click(object sender, EventArgs e)
        {
            agregarNumero("F");
        }

        /*Evento al dar click del boton Quitar*/
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            /*Si el número de digitos de la caja de resultado es mayor a uno, se obtiene la cadena sin el último dígito*/
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            /*Si solo hay un dígito por borrar, en la caja de resultado aparecerá un cero*/
            else
            {
                txtResultado.Text = "0";
            }
        }

        /*Evento al dar click del boton para borrar todo*/
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            /*Para la funcionalidad, solo se reemplazará todo por un cero*/
            txtResultado.Text = "0";
        }

        /*Evento al dar click del boton igual o convertidor (=)*/
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            /*Primero se guarda, en la variable respaldo, de tipo string, el número a ser convertido*/
            string respaldo = txtResultado.Text;

            /*Este es el primer caso en que se quiera convertir de BaseN a Base10*/
            if (cbxConvertirNum.Text == "10")
            {
                /*Se crea la variable booleana dividir (su valor nos dirá si el número debe ser dividido en parte entera y parte decimal)*/
                bool dividir = false;

                /*Se crea las variables de tipo string para almacenar la parte entera y la parte decimal*/
                string parteEntera, parteDecimal;

                /*Se inicia un bucle foreach para recorrer todo la caja de resultado, esto para saber si el número a ser convertido,
                  contiene un punto decimal*/
                foreach (char elem in txtResultado.Text)
                {
                    /*Si tiene punto decimal, la variable dividir será verdadera, por tanto se partirá al número en parte entera y parte decimal*/
                    if (elem == '.')
                        dividir = true;
                }

                /*Si dividir es verdadero, se procede con el algoritmo para partir al número en las dos partes*/
                if (dividir)
                {
                    /*Se inicia un array, en cual se almacenará la parte entera y la parte decimal*/
                    string[] numSeparado = txtResultado.Text.Split('.');

                    /*La variable parteEntera se quedará con la primera posicion del array, y la variable parteDecimal se quedará con la
                      segunda posición del array*/
                    parteEntera = numSeparado[0];
                    parteDecimal = numSeparado[1];

                    /*Si en el número había un punto decimal, pero sin digitos decimales, se tomara a la parte decimal como 0*/
                    if (parteDecimal == "")
                        parteDecimal = "0";
                }
                /*Si no se debe separar al número en parte entera y parte decimal, entonces solo se trabaja con el número completo, que su valor
                  será tomado por la variable parteEntera*/
                else
                {
                    parteEntera = txtResultado.Text;
                    parteDecimal = "0";
                }

                /*Se declará la variable rpta (Donde se almacenará el número convertido en la base10. Se hace uso de funciones explicadas)*/
                double rpta = DevolverParteEntera(parteEntera, int.Parse(cbxBaseNum.Text)) + DevolverParteDecimal(parteDecimal, int.Parse(cbxBaseNum.Text));

                /*Finalmente, se convierte la variable rpta a cadena de texto, para ser mostrada en la caja de resultado*/
                txtResultado.Text = rpta.ToString();
            }
            /*Este es el segundo caso en que se quiera convertir de Base10 a BaseN*/
            else if (cbxBaseNum.Text == "10")
            {
                /*Se crea la variable booleana dividir1 (su valor nos dirá si el número debe ser dividido en parte entera y parte decimal)*/
                bool dividir1 = false;

                /*Se crea la variable de tipo string para almacenar la parte entera, no necesitamos almacenar la parte decimal*/
                string parteEntera1;

                /*Se inicia un bucle foreach para recorrer todo la caja de resultado, esto para saber si el número a ser convertido,
                  contiene un punto decimal*/
                foreach (char elem in txtResultado.Text)
                {
                    if (elem == '.')
                        dividir1 = true;
                }
                /*Si dividir es verdadero, se procede con el algoritmo para partir al número en las dos partes*/
                if (dividir1)
                {
                    /*Se inicia un array, en cual se almacenará la parte entera y la parte decimal*/
                    string[] numSeparado1 = txtResultado.Text.Split('.');

                    /*La variable parteEntera1 se quedará con la primera posicion del array, y la segunda posición del array no se usará*/
                    parteEntera1 = numSeparado1[0];
                }
                /*Si no se halló un punto decimal, entonces solo se trabaja con el número completo, que su valor
                  será tomado por la variable parteEntera1*/
                else
                    parteEntera1 = txtResultado.Text;

                /*Se declará la variable de tipo double, numCompleto (Donde se almacenará el número a ser convertido)*/
                double numCompleto = double.Parse(txtResultado.Text);

                /*La caja de texto, mostrará el resultado, gracias al uso de las funciones de conversión*/
                txtResultado.Text = DevolverParteEntera1(int.Parse(parteEntera1), int.Parse(cbxConvertirNum.Text)) + DevolverParteDecimal1(numCompleto, int.Parse(cbxConvertirNum.Text));
            }
            /*Este es el tercer caso en que se quiera convertir de BaseN a BaseM (Aquí se combina el uso del primer y segundo caso)*/
            else
            {
                /*Se crea la variable booleana dividir (su valor nos dirá si el número debe ser dividido en parte entera y parte decimal)*/
                bool dividir = false;

                /*Se crea las variables de tipo string para almacenar la parte entera y la parte decimal*/
                string parteEntera, parteDecimal;

                /*Se inicia un bucle foreach para recorrer todo la caja de resultado, esto para saber si el número a ser convertido,
                  contiene un punto decimal*/
                foreach (char elem in txtResultado.Text)
                {
                    if (elem == '.')
                        dividir = true;
                }
                /*Si dividir es verdadero, se procede con el algoritmo para partir al número en las dos partes*/
                if (dividir)
                {
                    /*Se inicia un array, en cual se almacenará la parte entera y la parte decimal*/
                    string[] numSeparado = txtResultado.Text.Split('.');

                    /*La variable parteEntera se quedará con la primera posicion del array, y la variable parteDecimal se quedará con la
                      segunda posición del array*/
                    parteEntera = numSeparado[0];
                    parteDecimal = numSeparado[1];

                    /*Si en el número había un punto decimal, pero sin digitos decimales, se tomara a la parte decimal como 0*/
                    if (parteDecimal == "")
                        parteDecimal = "0";
                }
                /*Si no se debe separar al número en parte entera y parte decimal, entonces solo se trabaja con el número completo, que su valor
                  será tomado por la variable parteEntera*/
                else
                {
                    parteEntera = txtResultado.Text;
                    parteDecimal = "0";
                }

                /*Se declará la variable rpta (Donde se almacenará el número convertido en la base10. Se hace uso de funciones explicadas)*/
                double rpta = DevolverParteEntera(parteEntera, int.Parse(cbxBaseNum.Text)) + DevolverParteDecimal(parteDecimal, int.Parse(cbxBaseNum.Text));

                /*Luego, se convierte la variable rpta a cadena de texto, para ser almacenada en la variable rptaEnCadena de tipo string*/
                string rptaEnCadena = rpta.ToString();

                /*Se crea la variable booleana dividir1 (su valor nos dirá si el número debe ser dividido en parte entera y parte decimal)*/
                bool dividir1 = false;

                /*Se crea la variable de tipo string para almacenar la parte entera, no necesitamos almacenar la parte decimal*/
                string parteEntera1;

                /*Se inicia un bucle foreach para recorrer todo la caja de resultado, esto para saber si el número a ser convertido,
                  contiene un punto decimal*/
                foreach (char elem in rptaEnCadena)
                {
                    if (elem == '.')
                        dividir1 = true;
                }
                /*Si dividir es verdadero, se procede con el algoritmo para partir al número en las dos partes*/
                if (dividir1)
                {
                    /*Se inicia un array, en cual se almacenará la parte entera y la parte decimal*/
                    string[] numSeparado1 = rptaEnCadena.Split('.');

                    /*La variable parteEntera1 se quedará con la primera posicion del array, y la segunda posición del array no se usará*/
                    parteEntera1 = numSeparado1[0];
                }
                /*Si no se halló un punto decimal, entonces solo se trabaja con el número completo, que su valor
                  será tomado por la variable parteEntera1*/
                else
                    parteEntera1 = rptaEnCadena;

                /*Se declará la variable de tipo double, numCompleto (Donde se almacenará el número a ser convertido)*/
                double numCompleto = double.Parse(rptaEnCadena);

                /*La caja de texto, mostrará el resultado, gracias al uso de las funciones de conversión*/
                txtResultado.Text = DevolverParteEntera1(int.Parse(parteEntera1), int.Parse(cbxConvertirNum.Text)) + DevolverParteDecimal1(numCompleto, int.Parse(cbxConvertirNum.Text));
            }
            /*Luego el número que fue convertido se mostrará encima del número en la otra base*/
            txtMostrar.Text = respaldo;

            /*Al terminar el proceso de conversión, se procede a registrar la conversión en el historial*/
            rtbHistorial.Text += respaldo + " (base " + cbxBaseNum.Text + ") = " + txtResultado.Text + " (base " + cbxConvertirNum.Text + ") \n";

            /*Se vuelve a habilitar los combobox, que se inabilitan al iniciarse un proceso de conversión*/
            cbxBaseNum.Enabled = true; cbxConvertirNum.Enabled = true;

            /*Tambien se deshabilita los siguientes botones, porque estos ya fueron usados para ingresar el número, 
              para ingresar un núevo número, se tiene que empezar nuevamente otro proceso de conversión*/
            btn0.Enabled = false; btn1.Enabled = false; btn2.Enabled = false; btn3.Enabled = false; btn4.Enabled = false;
            btn5.Enabled = false; btn6.Enabled = false; btn7.Enabled = false; btn8.Enabled = false; btn9.Enabled = false;
            btnA.Enabled = false; btnB.Enabled = false; btnC.Enabled = false; btnD.Enabled = false; btnE.Enabled = false;
            btnF.Enabled = false; btnPunto.Enabled = false; btnConvertir.Enabled = false;
        }

        /*Evento al dar click en el boton Historial*/
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            /*Se alarga la medida del panel y aparece el historial*/
            PnlHistorial.Height = (PnlHistorial.Height == 5) ? PnlHistorial.Height = 345 : 5;
        }

        /*Evento al dar click en el boton Historial*/
        private void btnVaciarHistorial_Click(object sender, EventArgs e)
        {
            /*Se borra todo el richtextbox del historial*/
            rtbHistorial.Text = "";
        }

        /*Evento click del boton iniciar*/
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                /*Solo se inicia el proceso de conversión si los combobox estan en el rando de (2 a 16)*/
                if (int.Parse(cbxBaseNum.Text) >= 2 && int.Parse(cbxBaseNum.Text) <= 16 &&
                    int.Parse(cbxConvertirNum.Text) >= 2 && int.Parse(cbxConvertirNum.Text) <= 16)
                {
                    /*Se limpia el textbox de resultados*/
                    txtResultado.Text = "0"; txtMostrar.Text = "0";

                    /*Se deshabilitan los combobox, para evitar el cambio repentino de base*/
                    cbxBaseNum.Enabled = false; cbxConvertirNum.Enabled = false;

                    /*Si los combobox contienen la base del numero y la base a la que se convertirá se puede continuar*/
                    if (cbxBaseNum.Text != "" && cbxConvertirNum.Text != "")
                    {
                        /*Se habilita el boton para la conversion, boton igual (=)*/
                        btnConvertir.Enabled = true;

                        /*Se habilita el boton punto decimal*/
                        btnPunto.Enabled = true;

                        /*Se Habilitan los botones según la base del numero a ser convertido*/
                        if (cbxBaseNum.Text == "2")
                        {
                            btn0.Enabled = true; btn1.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "3")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "4")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "5")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "6")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "7")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true; btn6.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "8")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "9")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true; btn8.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "10")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true; btn8.Enabled = true; btn9.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "11")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true; btn8.Enabled = true; btn9.Enabled = true;
                            btnA.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "12")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true; btn8.Enabled = true; btn9.Enabled = true;
                            btnA.Enabled = true; btnB.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "13")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true; btn8.Enabled = true; btn9.Enabled = true;
                            btnA.Enabled = true; btnB.Enabled = true; btnC.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "14")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true; btn8.Enabled = true; btn9.Enabled = true;
                            btnA.Enabled = true; btnB.Enabled = true; btnC.Enabled = true; btnD.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "15")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true; btn8.Enabled = true; btn9.Enabled = true;
                            btnA.Enabled = true; btnB.Enabled = true; btnC.Enabled = true; btnD.Enabled = true; btnE.Enabled = true;
                        }
                        else if (cbxBaseNum.Text == "16")
                        {
                            btn0.Enabled = true; btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
                            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true; btn8.Enabled = true; btn9.Enabled = true;
                            btnA.Enabled = true; btnB.Enabled = true; btnC.Enabled = true; btnD.Enabled = true; btnE.Enabled = true;
                            btnF.Enabled = true;
                        }
                    }
                }
                /*Si los números ingresados en el combobox no son válidos se borran*/
                else
                {
                    cbxBaseNum.Text = "";
                    cbxConvertirNum.Text = "";
                }
            }
            catch {}
        }

        /*Evento click del boton cancelar*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /*Se vuelve a habilitar los combobox*/
            cbxBaseNum.Enabled = true; cbxConvertirNum.Enabled = true;

            /*Se deshabilitan los siguientes botones*/
            btn0.Enabled = false; btn1.Enabled = false; btn2.Enabled = false; btn3.Enabled = false; btn4.Enabled = false;
            btn5.Enabled = false; btn6.Enabled = false; btn7.Enabled = false; btn8.Enabled = false; btn9.Enabled = false;
            btnA.Enabled = false; btnB.Enabled = false; btnC.Enabled = false; btnD.Enabled = false; btnE.Enabled = false;
            btnF.Enabled = false; btnPunto.Enabled = false; btnConvertir.Enabled = false;
        }

        /*Evento click del boton cerrar*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Evento click del boton maximizar*/
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        /*Evento click del boton minimizar*/
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*Evento click del boton cancelar*/
        /*Código para mover el formulario*/
        int posY = 0, posX = 0;
        private void PnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}

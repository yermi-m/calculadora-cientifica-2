using System;

namespace BibliotecaDeLosMetodos
{
	public static class Metodos
	{
		public static bool ExpresionValida(string argumento)
		{
			// esta funcion debe verificar que el argumento cumple con la 
			// nomenclatura de una expresion matematica

			//verificar que la expresion no contiene caracteres ajenos a una expresion matematica. 
			//verificar que el primer y ultimo caracter de la expresion cumple con la nomenclatura. 
			//verificar que los demas caracteres de la expresion cumplen con la nomenclatura. 
			//verificar que no haya parentesis sin pareja.
			//verificar que los numeros no tengan mas de un punto. 
			//verificar que los numeros no tengan mas de una "E".
			//verificar que los numeros tengan la "E" despues del punto en caso de ser un numero con punto.

			// aqui vamos a verificar que la expresion no contiene caracteres ajenos a una expresion matematica.
			foreach (char item in argumento)
			{
				switch (item)
				{
					case 'E':
					case 'e':
					case '.':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					case '*':
					case '/':
					case '+':
					case '-':
					case '(':
					case ')':
						// en caso de que el caracter sea igual a algunos de estos entonces seguirá la iteracion del bucle
						continue;
					default:
						return false;
				}
			}

			// ahora vamos a verificar que el primer y ultimo caracter de la expresion cumple con la nomenclatura. 
			string valoresCorrectos = "(-.0123456789"; // estos son los valores con los que puede comenzar una expresion
			for (int indice1 = 0; indice1 < valoresCorrectos.Length; indice1++)
			{
				if (argumento[0] == valoresCorrectos[indice1])
				{
					break;
				}
				if (indice1 == valoresCorrectos.Length - 1)
				{
					return false;
				}
			}
			valoresCorrectos = ")0123456789"; // estos son los valores con los que puede terminar una expresion.
			for (int indice1 = 0; indice1 < valoresCorrectos.Length; indice1++)
			{
				if (argumento[argumento.Length - 1] == valoresCorrectos[indice1])
				{
					break;
				}
				if (indice1 == valoresCorrectos.Length - 1)
				{
					return false;
				}
			}

			// ahora vamos a verificar que los demas caracteres de la expresion cumplen con la nomenclatura.
			
			// lo haremos verificando si el caracter siguiente es el correcto
			// segun la nomenclatura de una expresion matematica.
			for (int indice1 = 0; indice1 < argumento.Length; indice1++)
			{
				switch (argumento[indice1])
				{
					case 'E':
					case 'e':
					case '.':
						// si el carecter actual es un punto, 'E', 'e', entonces el siguiente caracter debe ser:
						// un numero.
						// si no es igual a nada de lo anterior entonces devolverá falso.
						valoresCorrectos = "0123456789";
						int indice2 = 0;
						foreach (char item in valoresCorrectos)
						{
							if (indice1 < argumento.Length - 1 && argumento[indice1 + 1] == item)
							{
								break;
							}
							if (indice1 < argumento.Length - 1 && indice2 == valoresCorrectos.Length - 1)
							{
								return false;
							}
							indice2++;
						}
						break;
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
						// si el carecter actual es un numero, entonces el siguiente caracter debe ser:
						// caracteres de numero, un operador, o un parentesis cerrado.
						// si no es igual a nada de lo anterior entonces devolverá falso.
						valoresCorrectos = "0123456789.Ee*/+-)";
						indice2 = 0;
						foreach (char item in valoresCorrectos)
						{
							if (indice1 < argumento.Length - 1 && argumento[indice1 + 1] == item)
							{
								break;
							}
							if (indice1 < argumento.Length - 1 && indice2 == valoresCorrectos.Length - 1)
							{
								return false;
							}
							indice2++;
						}
						break;
					case '*':
					case '/':
					case '+':
					case '-':
						// si el carecter actual es un operador,
						// entonces el siguiente caracter debe ser:
						// caracteres de numero excluyendo la 'E', o un parentesis abierto.
						// si no es igual a nada de lo anterior entonces devolverá falso.
						valoresCorrectos = "0123456789.(";
						indice2 = 0;
						foreach (char item in valoresCorrectos)
						{
							if (indice1 < argumento.Length - 1 && argumento[indice1 + 1] == item)
							{
								break;
							}
							if (indice1 < argumento.Length - 1 && indice2 == valoresCorrectos.Length - 1)
							{
								return false;
							}
							indice2++;
						}
						break;
					case '(':
						// si el carecter actual es un parentesis abierto,
						// entonces el siguiente caracter debe ser:
						// caracteres de numero excluyendo la 'E', signo de numero negativo, o un parentesis abierto.
						// si no es igual a nada de lo anterior entonces devolverá falso.
						valoresCorrectos = "0123456789.-(";
						indice2 = 0;
						foreach (char item in valoresCorrectos)
						{
							if (indice1 < argumento.Length - 1 && argumento[indice1 + 1] == item)
							{
								break;
							}
							if (indice1 < argumento.Length - 1 && indice2 == valoresCorrectos.Length - 1)
							{
								return false;
							}
							indice2++;
						}
						break;
					case ')':
						// si el carecter actual es un parentesis cerrado,
						// entonces el siguiente caracter debe ser:
						// un parentesis cerrado, o un operador.
						// si no es igual a nada de lo anterior entonces devolverá falso.
						valoresCorrectos = ")*/+-";
						indice2 = 0;
						foreach (char item in valoresCorrectos)
						{
							if (indice1 < argumento.Length - 1 && argumento[indice1 + 1] == item)
							{
								break;
							}
							if (indice1 < argumento.Length - 1 && indice2 == valoresCorrectos.Length - 1)
							{
								return false;
							}
							indice2++;
						}
						break;
					default:
						break;
				}
			}

			// aqui vamos a verificar que no haya parentesis sin pareja.
			int parentesisAbiertos = 0, parentesisCerrados = 0;
			foreach (char item in argumento)
			{
				if (item == '(')
				{
					parentesisAbiertos++;
				}
				if (item == ')')
				{
					parentesisCerrados++;
				}
			}
			if (parentesisAbiertos != parentesisCerrados)
			{
				// si la cantidad de parentesis abiertos no es igual que la cantidad de
				// parentesis cerrados, entonces devolerá falso.
				return false;
			}

            // ahora vamos a verificar tres cosas:
            // que los numeros no tengan mas de un punto, 
            // que los numeros no tengan mas de una "E", 
            // que los numeros tengan la "E" despues del punto en caso de ser un numero con punto.

            string numeroParaVerificar = "";
            foreach (char item in argumento)
			{
				switch (item)
				{
					case '*':
					case '/':
					case '+':
					case '-':
					case '(':
					case ')':
						// si el caracter es un operador, o un parentesis,
						// entonces dejar de guardar los valores en la variable y
						// verificar las tres cosas.

						// primero, verificamos la cantidad de punto y la cantidad de "E".
						int cantidadDePuntos = 0, cantidadDeE = 0, indiceDelPunto = 0, indiceDeLaE = 0, indice1 = 0;

						foreach (char item2 in numeroParaVerificar)
						{
							if (item2 == '.')
							{
								cantidadDePuntos++;
								indiceDelPunto = indice1;
							}
							if (item2 == 'E' || item2 == 'e')
							{
								cantidadDeE++;
								indiceDeLaE = indice1;
							}
							if (cantidadDePuntos > 1 || cantidadDeE > 1)
							{
								// si la cantidad de puntos, o la cantidad de 'E' sobrepasa el 1, entonces devolverá falso.
								return false;
							}
							indice1++;
						}
                        // segundo, verificamos que el numero tengan la "E" despues del punto en caso de ser un numero con punto.
                        if ((cantidadDePuntos > 0 && cantidadDeE > 0) && (indiceDeLaE < indiceDelPunto))
                        {
							return false;
                        }
                        continue;
					default:
						// si el caracter no es un operador ni un parentesis, 
						// quiere decir que es algo que forme parte de un numero, 
						// entonces se guardará en la variable para luego poder verificar si hay mas de un punto.
						numeroParaVerificar += item;
						continue;
				}
			}
			return true;
		}
		public static string FormatearResultado(string argumento)
		{
            // esta funcion es para visualizar el resultado con
            // separador de millares y para eliminar los ceros a la izquierda y
            // ceros a la derecha despues del punto.

            // asi es como funciona:
            // 001234567.9E900	resultado de ejemplo
            // 1234567.9E9		eliminar ceros a la izquierda y a la derecha despues del punto
            //					guardar la parte entera y la parte decimal en variables separadas
            // 1234567			parte entera
            // .9E9				parte decimal
            // 7654321			poner la parte entera al reves
            // 765,432,1		agregar las comas
            // 1,234,567		volver a poner la parte entera en direccion normal
            // 1,234,567.9E9	unir las dos partes

            // eliminar ceros a la izquierda y a la derecha despues del punto.
            double argumento2 = Convert.ToDouble(argumento);
			argumento = Convert.ToString(argumento2);

			// guardar la parte entera y la parte decimal en variables separadas
			string parteEntera = "", parteDecimal = "";
			bool despuesDelPunto = false;
			foreach (char item in argumento)
			{
				if (item == '.')
				{
					despuesDelPunto = true;
				}
				if (despuesDelPunto)
				{
					parteDecimal += item;
				}
				else
				{
					parteEntera += item;
				}
			}

            // poner la parte entera al reves.
            string argumento3 = "";
			for (int indice = parteEntera.Length - 1; indice >= 0; indice--)
			{
				argumento3 += parteEntera[indice];
			}
			
			// agregar las comas
			string argumento4 = "";
			int contador = 0;
			foreach (char item in argumento3)
			{
				if (contador == 3)
				{
					argumento4 += "," + item;
					contador = 0;
				}
				else
				{
                    argumento4 += item;
                }
				contador++;
			}

            // volver a poner la parte entera en direccion normal
            string argumento5 = "";
            for (int indice = argumento4.Length - 1; indice >= 0; indice--)
            {
                argumento5 += argumento4[indice];
            }

            // unir las dos partes

            return argumento5 + parteDecimal;
		}
		public static string ConvertirMatrizEnString(string[] arreglo)
		{
			// lo siguiente es para convertir el arreglo a un string
			string conversionEnString = "";
			foreach (string item in arreglo)
			{
				conversionEnString += item;
			}

			return conversionEnString;
		}
		public static string PreformatearExpresion(string argumento)
        {
            //Esta funcion elimina los espacios y las comas que tenga la expresion.
            //En caso de que la expresion no tenga ningun caracter retornar "0".

            // lo siguiente es para eliminar los espacios y las comas.
            string nuevoArgumentoSinEspacios = "";
            foreach (char item in argumento)
            {
                if (item == ' ' || item == ',')
                {
                    continue;
                }
                nuevoArgumentoSinEspacios += item;
            }

            // lo siguiente es para devolver '0' en caso de que la expresion no contenga ningun caracter
            if (argumento == "" || nuevoArgumentoSinEspacios == "")
            {
                return "0";
            }

            return nuevoArgumentoSinEspacios;
        }
        public static string[] LimpiarMatriz(string[] expresionMatematica)
		{
            // esta funcion es para eliminar las posiciones vacias del arreglo.

            // primero contamos las posiciones vacias del arreglo
            int cantidadDeEspacios = 0;
            foreach (string item in expresionMatematica)
            {
                if (item == null)
                {
                    cantidadDeEspacios++;
                }
            }

            // luego copiamos solo las posiciones que no son vacias al nuevo arreglo.
            string[] arreglo2 = new string[expresionMatematica.Length - cantidadDeEspacios];
            int indice = 0;
            foreach (string item in expresionMatematica)
			{
				switch (item)
				{
                    case null:

						continue;
					default:
						arreglo2[indice] = item;
						indice++;
						break;
				}
			}

			return arreglo2;
		}
		public static string CalcularExpresion(string expresionMatematica)
		{
			/* Esta funcion es para calcular la expresion con parentesis y todo eso.
			
			esta funcion funciona de la siguiente manera:

			un bucle para contar las cantidad de parentesis abierto;
			un bucle que se repetirá la misma cantidad de veces que hay de parentesis abiertos
			{
				un bucle para encontrar el ultimo parentesis abierto del arreglo;
				un bucle para encontrar el parentesis cerrado del parentesis anterior;

				una vez que tenemos la posicion de inicio y fin de esta pareja de parentesis 
				entonces procedemos con las instrucciones para calcular la expresion dentro de estos parentesis;
			}
			luego, en caso de que haya o no expresiones dentro de parentesis, terminar de 
			resolver el calculo de la expresion;
			*/

			// primero, preformateamos la entrada
			expresionMatematica = Metodos.PreformatearExpresion(expresionMatematica);

			// segundo, validamos que la entrada sea valida
			if (Metodos.ExpresionValida(expresionMatematica))
			{
				// ahora convertimos la expresion en un arreglo
				string[] arregloBase = Metodos.ConvertirStringEnMatriz(expresionMatematica);

				// esto es para contar las cantidad de parentesis abiertos que hay en la expresion matematica.
				int parentesisAbiertos = 0;
				foreach (string item in arregloBase)
				{
					if (item == "(")
					{
						parentesisAbiertos++;
					}
				}
				// este es un bucle que se repetirá la misma cantidad de veces que hay de parentesis abiertos
				int inicioDelUltimoParentesis, finDelUltimoParentesis;
				for (int indice = 0; indice < parentesisAbiertos; indice++)
				{
					// esto es para encontrar el ultimo parentesis abierto del arreglo
					inicioDelUltimoParentesis = 0;
					for (int indice_2 = 0; indice_2 < arregloBase.Length; indice_2++)
					{
						if (arregloBase[indice_2] == "(")
						{
							inicioDelUltimoParentesis = indice_2;
						}
					}
					// esto es para encontrar el parentesis cerrado del parentesis anterior
					finDelUltimoParentesis = 0;
					for (int indice_3 = 0; indice_3 < arregloBase.Length; indice_3++)
					{
						if (arregloBase[indice_3] == ")" && indice_3 > inicioDelUltimoParentesis)
						{
							finDelUltimoParentesis = indice_3;
							break;
						}
					}

					// esto es para copiar lo que hay dentro de los parentesis a otro arreglo
					string[] arregloEntreParentesis = new string[arregloBase.Length];
					int indice_5 = 0;
					for (int indice_4 = inicioDelUltimoParentesis + 1; indice_4 < finDelUltimoParentesis; indice_4++)
					{
						arregloEntreParentesis[indice_5] = arregloBase[indice_4];
						indice_5++;
					}

					// ahora limpiamos el arreglo
					arregloEntreParentesis = Metodos.LimpiarMatriz(arregloEntreParentesis);

					// ahora asignamos el valor del calculo a la posicion donde inicia el parentesis
					arregloBase[inicioDelUltimoParentesis] = Metodos.CalcularExpresionSinParentesis(arregloEntreParentesis);

					// ahora asignamos un valor nulo a las otras posiciones hasta donde termina el
					// parentesis y luego limpiamos el arreglo
					for (int indice_6 = inicioDelUltimoParentesis + 1; indice_6 <= finDelUltimoParentesis; indice_6++)
					{
						arregloBase[indice_6] = null;
					}
					arregloBase = Metodos.LimpiarMatriz(arregloBase);

				}

				// luego que ya se ha resuelto todas las expresiones que están dentro de parentesis, ahora
				// se resuelve lo que está afuera de los parentesis y ese valor resultante es 
				// lo que se va a retornar.

				return Metodos.FormatearResultado(Metodos.CalcularExpresionSinParentesis(arregloBase));
			}
			else
			{
				return "ENTRADA NO VALIDA";
			}
		}
		public static string[] ConvertirStringEnMatriz(string expresionMatematica)
		{
			// esta funcion es para convertir la expresion matematica
			// en un arreglo para poder trabajarlo de la manera que necesito

			// este bucle es para recorrer la expresion e ir asignando el digito a cada posicion del segundo arreglo
			string[] arregloIntermediario = new string[expresionMatematica.Length];
			int indice_2 = 0;

			for (int indice_1 = 0; indice_1 < expresionMatematica.Length; indice_1++)
			{
				switch (expresionMatematica[indice_1])
				{
					case '(':
						arregloIntermediario[indice_2] += expresionMatematica[indice_1];
						indice_2++;
						break;
					case ')':
						indice_2++;
						arregloIntermediario[indice_2] += expresionMatematica[indice_1];
						break;
					case '*':
						indice_2++;
						arregloIntermediario[indice_2] += expresionMatematica[indice_1];
						indice_2++;
						break;
					case '/':
						indice_2++;
						arregloIntermediario[indice_2] += expresionMatematica[indice_1];
						indice_2++;
						break;
					case '+':
						indice_2++;
						arregloIntermediario[indice_2] += expresionMatematica[indice_1];
						indice_2++;
						break;
					case '-':
						// esto es para evaluar si debo tratar el signo como un
						// signo de numero negativo o como un operador
						if ((indice_1 == 0) || (expresionMatematica[indice_1 - 1] == '('))
						{
							arregloIntermediario[indice_2] += expresionMatematica[indice_1];
						}
						else
						{
							indice_2++;
							arregloIntermediario[indice_2] += expresionMatematica[indice_1];
							indice_2++;
						}
						break;
					default:
						arregloIntermediario[indice_2] += expresionMatematica[indice_1];
						break;
				}
			}

			// ahora vamos a eliminar los parentesis que pertenecen a un numero negativo y no a una expresion
			for (int indice = 0; indice < arregloIntermediario.Length; indice++)
			{
				if ((arregloIntermediario[indice] == "(") && (arregloIntermediario[indice + 2]) == ")")
				{
					arregloIntermediario[indice] = null;
					arregloIntermediario[indice + 2] = null;
				}
			}
			return Metodos.LimpiarMatriz(arregloIntermediario);
		}
		public static string CalcularExpresionSinParentesis(string[] expresionMatematica)
		{
			// esta funcion es para calcular una expresion matematica sin parentesis.

			expresionMatematica = Metodos.MultiplicacionYdivision(expresionMatematica);
			expresionMatematica = Metodos.SumaYresta(expresionMatematica);

			return Metodos.ConvertirMatrizEnString(expresionMatematica);
		}
		public static string[] MultiplicacionYdivision(string[] expresionMatematica)
		{
			// esta funcion es para hacer las multiplicaciones y divisiones de la expresion

			double num_1, num_2;

			// este bucle es para calcular las multiplicaciones y divisiones
			for (int indice = 0; indice < expresionMatematica.Length; indice++)
			{
				// aqui se hace la multiplicacion y division, y el 
				// resultado se asigna en la posicion del
				// segundo operando. Y luego la posicion del primer operando y 
				// la posicion del operador quedan en blanco.
				switch (expresionMatematica[indice])
				{
					case "*":
						num_1 = Convert.ToDouble(expresionMatematica[indice - 1]);
						num_2 = Convert.ToDouble(expresionMatematica[indice + 1]);
						expresionMatematica[indice + 1] = Convert.ToString(num_1 * num_2);

						expresionMatematica[indice - 1] = "";
						expresionMatematica[indice] = "";
						break;
					case "/":
						num_1 = Convert.ToDouble(expresionMatematica[indice - 1]);
						num_2 = Convert.ToDouble(expresionMatematica[indice + 1]);

						// en caso de que el segundo operando sea 0 entonces
						// el primer operando sera igual a 0.
						// Esto es para evitar problemas al dividir entre 0.
						if (num_2 == 0)
						{
							num_1 = 0;
						}
						expresionMatematica[indice + 1] = Convert.ToString(num_1 / num_2);

						expresionMatematica[indice - 1] = "";
						expresionMatematica[indice] = "";
						break;
					default:
						break;
				}
			}
			// lo siguiente es para quitarle las posiciones vacias al arreglo que será devuelto
			expresionMatematica = Metodos.LimpiarMatriz(expresionMatematica);

			return expresionMatematica;
		}
		public static string[] SumaYresta(string[] expresionMatematica)
		{
			// esta funcion es para hacer las sumas  y restas de la expresion

			double num_1, num_2;

			// este bucle es para calcular las multiplicaciones y divisiones
			for (int indice = 0; indice < expresionMatematica.Length; indice++)
			{
				// aqui se hace la suma y resta, y el 
				// resultado se asigna en la posicion del
				// segundo operando. Y luego la posicion del primer operando y 
				// la posicion del operador quedan en blanco.
				switch (expresionMatematica[indice])
				{
					case "+":
						num_1 = Convert.ToDouble(expresionMatematica[indice - 1]);
						num_2 = Convert.ToDouble(expresionMatematica[indice + 1]);
						expresionMatematica[indice + 1] = Convert.ToString(num_1 + num_2);

						expresionMatematica[indice - 1] = "";
						expresionMatematica[indice] = "";
						break;
					case "-":
						num_1 = Convert.ToDouble(expresionMatematica[indice - 1]);
						num_2 = Convert.ToDouble(expresionMatematica[indice + 1]);

						expresionMatematica[indice + 1] = Convert.ToString(num_1 - num_2);

						expresionMatematica[indice - 1] = "";
						expresionMatematica[indice] = "";
						break;
					default:
						break;
				}
			}
			// lo siguiente es para quitarle las posiciones vacias al arreglo que será devuelto
			expresionMatematica = Metodos.LimpiarMatriz(expresionMatematica);

			return expresionMatematica;
		}
	}
}

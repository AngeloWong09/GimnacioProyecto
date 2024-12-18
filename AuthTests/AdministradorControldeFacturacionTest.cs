namespace GymFastForceTests
{
    [TestClass]
    public class AdministradorControldeFacturacionTest
    {
        /// <summary>
        /// Prueba que verifica si los datos del archivo CSV se cargan correctamente en la tabla.
        /// </summary>
        [TestMethod]
        public async Task CargarPagos_DeberiaCargarDatosCSVCorrectamente()
        {
            // Arrange: Simulamos el contenido del archivo CSV.
            string contenidoCSV = "FacturaId;UsuarioId;MesPago;Monto;FechaEmisión;FechaVencimiento;EstadoFactura;Clase\n" +
                                  "F001;1;Enero 2024;1000;01/01/2024;15/01/2024;Pagada;Cardio\n" +
                                  "F002;2;Febrero 2024;1500;01/02/2024;15/02/2024;Pendiente;Yoga\n";
            var lineasEsperadas = new string[]
            {
                "F001;1;Enero 2024;1000;01/01/2024;15/01/2024;Pagada;Cardio",
                "F002;2;Febrero 2024;1500;01/02/2024;15/02/2024;Pendiente;Yoga"
            };

            // Act: Simulamos la carga y procesamiento del archivo CSV.
            var respuesta = new MockHttpResponseMessage
            {
                Content = new StringContent(contenidoCSV)
            };
            var contenido = await respuesta.Content.ReadAsStringAsync(); // Obtiene el contenido del CSV

            // Procesamos el CSV para obtener los datos
            var datosCargados = ProcesarCSVTexto(contenido);

            // Assert: Verificamos que los datos se han cargado correctamente.
            Assert.AreEqual(2, datosCargados.Count);
            Assert.AreEqual(lineasEsperadas[0], string.Join(";", datosCargados[0]));
            Assert.AreEqual(lineasEsperadas[1], string.Join(";", datosCargados[1]));
        }

        /// <summary>
        /// Prueba que verifica si la tabla se filtra correctamente por mes seleccionado.
        /// </summary>
        [TestMethod]
        public void FiltrarPorMes_DeberiaMostrarSoloDatosDelMesSeleccionado()
        {
            // Arrange: Simulamos los datos cargados en la tabla
            var datosCSV = new List<string[]>
            {
                new string[] { "F001", "1", "Enero 2024", "1000", "01/01/2024", "15/01/2024", "Pagada", "Cardio" },
                new string[] { "F002", "2", "Febrero 2024", "1500", "01/02/2024", "15/02/2024", "Pendiente", "Yoga" }
            };

            // Act: Simulamos la selección del filtro para "Enero 2024"
            var mesSeleccionado = "Enero 2024";
            var facturasFiltradas = FiltrarPorMes(mesSeleccionado, datosCSV);

            // Assert: Verificamos que solo se muestren las facturas correspondientes a "Enero 2024"
            Assert.AreEqual(1, facturasFiltradas.Count);
            Assert.AreEqual("F001", facturasFiltradas[0][0]);
        }

        /// <summary>
        /// Prueba que verifica la función para agregar una nueva fila a la tabla.
        /// </summary>
        [TestMethod]
        public void AgregarFila_DeberiaAñadirUnaFilaCorrectamente()
        {
            // Arrange: Simulamos el estado inicial de la tabla
            var datosCSV = new List<string[]>
            {
                new string[] { "F001", "1", "Enero 2024", "1000", "01/01/2024", "15/01/2024", "Pagada", "Cardio" }
            };

            // Act: Llamamos a la función para agregar una nueva fila
            AgregarFila(datosCSV);

            // Assert: Verificamos que la nueva fila ha sido añadida
            Assert.AreEqual(2, datosCSV.Count);
            Assert.AreEqual("F000", datosCSV[1][0]);
            Assert.AreEqual("CardioDance", datosCSV[1][7]);
        }

        /// <summary>
        /// Prueba que verifica la funcionalidad de guardar los cambios en el CSV después de editar.
        /// </summary>
        [TestMethod]
        public void GuardarCambios_DeberiaGuardarCorrectamenteLosCambiosRealizados()
        {
            // Arrange: Simulamos la carga inicial de datos
            var datosCSV = new List<string[]>
            {
                new string[] { "F001", "1", "Enero 2024", "1000", "01/01/2024", "15/01/2024", "Pagada", "Cardio" }
            };

            // Act: Simulamos la edición de una fila y el guardado de los cambios
            var nuevaFila = new string[] { "F001", "1", "Enero 2024", "1200", "01/01/2024", "15/01/2024", "Pagada", "Cardio" }; // Cambio en Monto
            GuardarCambios(datosCSV, nuevaFila);

            // Assert: Verificamos que el monto ha sido actualizado correctamente
            Assert.AreEqual("1200", datosCSV[0][3]);
        }

        /// <summary>
        /// Prueba que verifica si el archivo CSV se genera correctamente con los datos visibles (filtrados).
        /// </summary>
        [TestMethod]
        public void GuardarCSV_DeberiaGenerarCSVConDatosFiltrados()
        {
            // Arrange: Simulamos los datos que serán exportados
            var datosCSV = new List<string[]>
            {
                new string[] { "F001", "1", "Enero 2024", "1000", "01/01/2024", "15/01/2024", "Pagada", "Cardio" },
                new string[] { "F002", "2", "Febrero 2024", "1500", "01/02/2024", "15/02/2024", "Pendiente", "Yoga" }
            };

            // Act: Generamos el CSV a partir de los datos filtrados
            var contenidoCSV = GenerarCSV(datosCSV);

            // Assert: Verificamos que el contenido del CSV es correcto
            Assert.IsTrue(contenidoCSV.Contains("F001"));
            Assert.IsTrue(contenidoCSV.Contains("F002"));
            Assert.IsFalse(contenidoCSV.Contains("Enero 2025"));
        }
    }
}


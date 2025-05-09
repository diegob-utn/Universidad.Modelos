using System;
using Universidad.API.Consumer;
using Universidad.Modelos;

namespace Universidad.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("probando evento");
            ProbarEventos("1");
            ProbarEventos("2");
            ProbarEventos("3");
            ProbarEventos("4");

            Console.WriteLine("probando certificados");
            ProbarCertificados("1");
            ProbarCertificados("2");
            ProbarCertificados("3");
            ProbarCertificados("4");

            Console.WriteLine("probando inscripción");
            ProbarInscripcion("1");
            ProbarInscripcion("2");
            ProbarInscripcion("3");
            ProbarInscripcion("4");

            Console.WriteLine("probando pagos");
            ProbarPagos("tarjeta");
            ProbarPagos("transferencia");
            ProbarPagos("tarjeta ac");
            ProbarPagos("actu");

            Console.WriteLine("probando participantes");
            ProbarParticipantes("1");
            ProbarParticipantes("2");
            ProbarParticipantes("3");
            ProbarParticipantes("4");

            Console.WriteLine("probando ponentes");
            ProbarPonentes("1");
            ProbarPonentes("2");
            ProbarPonentes("3");
            ProbarPonentes("4");

            Console.WriteLine("probando sesiones");
            ProbarSesiones("tarjeta");
            ProbarSesiones("transferencia");
            ProbarSesiones("transferencia");
            ProbarSesiones("transferencia");

            Console.ReadLine();
        }

        private static void ProbarEventos(string n)
        {
            Crud<Evento>.EndPoint = "https://localhost:7270/api/Eventos";

            var evento = Crud<Evento>.Create(new Evento
            {
                Nombre = n,
                Fecha = new DateTime(2000, 1, 1),
                Lugar = "Fica",
                Tipo = "Taller"
            });

            if(evento != null && evento.Id > 0)
            {
                evento.Nombre = "Poo Actualizado";
                Crud<Evento>.Update(evento.Id, evento);

                var eventos = Crud<Evento>.GetAll();
                foreach(var e in eventos)
                {
                    Console.WriteLine($"Id = {e.Id}, Nombre = {e.Nombre}, Fecha = {e.Fecha}, Lugar = {e.Lugar}, Tipo = {e.Tipo}");
                }

                Crud<Evento>.Delete(evento.Id);
            }
            else
            {
                Console.WriteLine("Error al crear evento.");
            }
        }

        private static void ProbarCertificados(string n)
        {
            Crud<Certificado>.EndPoint = "https://localhost:7270/api/Certificados";

            var certificado = Crud<Certificado>.Create(new Certificado
            {
                Nombre = n,
                FechaEmision = new DateTime(2000, 1, 1)
            });

            if(certificado != null && certificado.Id > 0)
            {
                certificado.Nombre = "Poo Actualizado";
                Crud<Certificado>.Update(certificado.Id, certificado);

                var certificados = Crud<Certificado>.GetAll();
                foreach(var c in certificados)
                {
                    Console.WriteLine($"Id = {c.Id}, Participante = {c.Participante}");
                }

                Crud<Certificado>.Delete(certificado.Id);
            }
            else
            {
                Console.WriteLine("Error al crear certificado.");
            }
        }

        private static void ProbarInscripcion(string n)
        {
            Crud<Inscripcion>.EndPoint = "https://localhost:7270/api/Inscripciones";

            var inscripcion = Crud<Inscripcion>.Create(new Inscripcion
            {
                Fecha = new DateTime(2000, 1, 1),
                Estado = n
            });

            if(inscripcion != null && inscripcion.Id > 0)
            {
                inscripcion.Estado = "Pendiente";
                Crud<Inscripcion>.Update(inscripcion.Id, inscripcion);

                var inscripciones = Crud<Inscripcion>.GetAll();
                foreach(var i in inscripciones)
                {
                    Console.WriteLine($"Id = {i.Id}, Estado = {i.Estado}, Fecha = {i.Fecha}");
                }

                Crud<Inscripcion>.Delete(inscripcion.Id);
            }
            else
            {
                Console.WriteLine("Error al crear inscripción.");
            }
        }

        private static void ProbarPagos(string n)
        {
            Crud<Pago>.EndPoint = "https://localhost:7270/api/Pagos";

            var pago = Crud<Pago>.Create(new Pago
            {
                Fecha = new DateTime(2000, 1, 1),
                Medio = n
            });

            if(pago != null && pago.Id > 0)
            {
                pago.Medio = "Transferencia";
                Crud<Pago>.Update(pago.Id, pago);

                var pagos = Crud<Pago>.GetAll();
                foreach(var p in pagos)
                {
                    Console.WriteLine($"Id = {p.Id}, Medio = {p.Medio}, Fecha = {p.Fecha}");
                }

                Crud<Pago>.Delete(pago.Id);
            }
            else
            {
                Console.WriteLine("Error al crear pago.");
            }
        }

        private static void ProbarParticipantes(string n)
        {
            Crud<Participante>.EndPoint = "https://localhost:7270/api/Participantes";

            var participante = Crud<Participante>.Create(new Participante
            {
                Nombre = n,
                Apellido = "B",
                Telefono = "0986778603"
            });

            if(participante != null && participante.Id > 0)
            {
                participante.Nombre = "Diego B Actualizado";
                Crud<Participante>.Update(participante.Id, participante);

                var participantes = Crud<Participante>.GetAll();
                foreach(var p in participantes)
                {
                    Console.WriteLine($"Id = {p.Id}, Nombre = {p.Nombre}");
                }

                Crud<Participante>.Delete(participante.Id);
            }
            else
            {
                Console.WriteLine("Error al crear participante.");
            }
        }

        private static void ProbarPonentes(string n)
        {
            Crud<Ponente>.EndPoint = "https://localhost:7270/api/Ponentes";

            var ponente = Crud<Ponente>.Create(new Ponente
            {
                Nombre = n,
                Apellido = "B"
            });

            if(ponente != null && ponente.Id > 0)
            {
                ponente.Nombre = "Poo Actualizado";
                Crud<Ponente>.Update(ponente.Id, ponente);

                var ponentes = Crud<Ponente>.GetAll();
                foreach(var p in ponentes)
                {
                    Console.WriteLine($"Id = {p.Id}, Nombre = {p.Apellido}");
                }

                Crud<Ponente>.Delete(ponente.Id);
            }
            else
            {
                Console.WriteLine("Error al crear ponente.");
            }
        }

        private static void ProbarSesiones(string n)
        {
            Crud<Sesion>.EndPoint = "https://localhost:7270/api/Sesiones";

            var sesion = Crud<Sesion>.Create(new Sesion
            {
                HoraInicio = new DateTime(2000, 2, 5),
                HoraFin = new DateTime(2000, 2, 2),
                Lugar = n
            });

            if(sesion != null && sesion.Id > 0)
            {
                sesion.Lugar = "Ficaya Actualizado";
                Crud<Sesion>.Update(sesion.Id, sesion);

                var sesiones = Crud<Sesion>.GetAll();
                foreach(var s in sesiones)
                {
                    Console.WriteLine($"Id = {s.Id}, Inicio = {s.HoraInicio}, Fin = {s.HoraFin}");
                }

                Crud<Sesion>.Delete(sesion.Id);
            }
            else
            {
                Console.WriteLine("Error al crear sesión.");
            }
        }
    }
}
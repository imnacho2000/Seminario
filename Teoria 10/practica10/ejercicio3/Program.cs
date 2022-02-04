using System;
using System.Linq;
using System.Collections.Generic;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var alumnos = Alumno.GetLista();
            var examenes =  Examen.GetLista();
            var cursos = Curso.GetLista();

            //Inciso A
            Console.WriteLine($"Inciso A: ");
            var listadoA = alumnos.GroupJoin(examenes, 
                            a => a._id,
                            e => e._alumnoId,
                            (a, examenes) => new
                            {
                                NombreAlumno = a._nombre,
                                Examenes = examenes
                            }).OrderBy(f => f.NombreAlumno);
            listadoA.Where(l => l.Examenes.Count() >0).ToList().ForEach(l => Console.WriteLine(l.NombreAlumno));

            //Inciso B
            Console.WriteLine($"Inciso B: ");
            var listadoB = cursos.GroupJoin(examenes, 
                            a => a._cursoId,
                            e => e.cursoId,
                            (a, examenes) => new
                            {
                                Cantidad = examenes,
                                Titulo = a._titulo,
                            }).Where(f => f.Cantidad.Count() >0).OrderBy(f => f.Cantidad.Count()).ToList(); 
            foreach (var obj in listadoB){
                Console.WriteLine($"titulo = {obj.Titulo}, cantidad = {obj.Cantidad.Count()}");
            }
            
            // Inciso C 
            Console.WriteLine($"Inciso C: ");
            var listadoAA = alumnos.GroupJoin(examenes, 
                            a => a._id,
                            e => e._alumnoId,
                            (a, examenes) => new
                            {
                                NombreAlumno = a._nombre,
                                id = a._id,
                                Examenes = examenes
                            }).Where(f => f.Examenes.Count() >0).OrderBy(f => f.NombreAlumno);
            var listadoC = cursos.Join(examenes, 
                            a => a._cursoId,
                            e => e.cursoId,
                            (a, examenes) => new
                            {
                                Cursos = a._titulo,
                                Examenes = examenes,
                            });
            var listadoInicisoC = listadoAA.Join(listadoC,
                            a => a.id,
                            c => c.Examenes._alumnoId,
                            (a,c) => new
                            {
                                NombreAlumno = a.NombreAlumno,
                                Titulo = c.Cursos,
                                Nota = c.Examenes._nota,
                            });
            foreach(var obj in listadoInicisoC){
                Console.WriteLine($"Alumno = {obj.NombreAlumno}, Curso = {obj.Titulo}, Nota = {obj.Nota}");
            }

            // Inciso D
            Console.WriteLine($"Inciso D: ");
            var listadoD = alumnos.GroupJoin(examenes, 
                            a => a._id,
                            e => e._alumnoId,
                            (a, examenes) => new
                            {
                                NombreAlumno = a._nombre,
                                id = a._id,
                                Examenes = examenes
                            }).Where(f => f.Examenes.Count() > 0).OrderBy(f => f.NombreAlumno);
            var listadoDD = cursos.Join(examenes, 
                            a => a._cursoId,
                            e => e.cursoId,
                            (a, examenes) => new
                            {
                                Cursos = a._titulo,
                                Examenes = examenes,
                            });
            var listadoInicisoD = listadoD.Join(listadoDD,
                            a => a.id,
                            c => c.Examenes._alumnoId,
                            (a,c) => new
                            {
                                NombreAlumno = a.NombreAlumno,
                                Titulo = c.Cursos,
                                Nota = c.Examenes._nota,
                            }).Where(f => f.Nota >= 6);
            foreach(var obj in listadoInicisoD){
                Console.WriteLine($"Alumno = {obj.NombreAlumno}, Curso = {obj.Titulo}, Nota = {obj.Nota}");
            }

            // Inciso E
            Console.WriteLine($"Inciso E: ");
            var listadoE = alumnos.GroupJoin(examenes, 
                            a => a._id,
                            e => e._alumnoId,
                            (a, examenes) => new
                            {
                                NombreAlumno = a._nombre,
                                Examenes = examenes
                            }).OrderBy(f => f.NombreAlumno);
            listadoE.Where(f => f.Examenes.Count() == 0).ToList().ForEach(obj => Console.WriteLine($"Alumno = {obj.NombreAlumno}"));

            // Inciso F 
            Console.WriteLine($"Inciso F: ");
            var listadoF = alumnos.GroupJoin(examenes, 
                    a => a._id,
                    e => e._alumnoId,
                    (a, eGroup) => new
                    {
                        Alumno = a,
                        Examenes = eGroup
                        
                    }).Where(p => p.Examenes.Count() >= 1).OrderBy(p => p.Alumno._nombre).ToList();
            foreach (var obj in listadoF){
                var promedio = obj.Examenes.Average(e => e._nota);
                Console.WriteLine($"Alumno = {obj.Alumno._nombre} , Promedio = {promedio}");
            }
        }
    class Alumno{
        public string _nombre {get;set;}
        public int _id {get;set;}
        public Alumno(string nombre, int id){
            this._nombre = nombre;
            this._id = id;
        }
        public override string ToString(){
            return $"{this._nombre}";
        }
        public static List<Alumno> GetLista(){
            return new List<Alumno>(){
                new Alumno("Juan",1),
                new Alumno("Ana",2),
                new Alumno("Andrés",3),
                new Alumno("Paula",4),
                new Alumno("Sebastian",5),
                new Alumno("María",6),
                new Alumno("Camila",7),
                new Alumno("Ivan",8),
                new Alumno("Raúl",9),
            };
        }

    }

    class Examen{
        public double _nota{get;set;}
        public int _alumnoId {get;set;}
        public int cursoId{get;set;}
        

        public Examen(int id, double nota, int idMateria){
            this._alumnoId = id;
            this.cursoId = idMateria;
            this._nota = nota;
        }

        public override string ToString(){
            return ($"Alumno = {this._alumnoId}, Nota = {this._nota}, Curso = {this.cursoId}");
        }
        public static List<Examen> GetLista(){
            return new List<Examen>(){
                new Examen(2,5,1),
                new Examen(4,7,5),
                new Examen(4,9,3),
                new Examen(3,10,4),
                new Examen(7,5,3),
                new Examen(2,8,4),
                new Examen(6,9,5),
                new Examen(9,7,1),
                new Examen(6,5,4),
                new Examen(9,1,4),
                new Examen(7,9,5),
            };
        }
    }
    class Curso{
        public string _titulo{get;set;}
        public int _cursoId {get;set;}

        public Curso(int cursoId, string titulo){
            this._titulo = titulo;
            this._cursoId = cursoId;
        }

        public override string ToString(){
            return ($"Titulo ={this._titulo}");
        }
        
        public static List<Curso> GetLista(){
            return new List<Curso>(){
                new Curso(1,"Ingles"),
                new Curso(2,"Matematicas"),
                new Curso(3,"Historia"),
                new Curso(4,"Geografia"),
                new Curso(5,"Literatura"),
                new Curso(6,"Contabilidad"),
            };
        }
    }
    }
}



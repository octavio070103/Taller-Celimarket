namespace CapaLogica
{
    public class UsuariosBLL
    {
        public int ID {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
            
        public int Dni { get; set; }
        public string Email {  get; set; }

        public string Password {  get; set; }

        public string Telefono {  get; set; }

        public string Domicilio { get; set; }

        public int Perfil {  get; set; }

        //aca establesco el atributo fotoUSUario qeu va a ser un arreglo byte para guardar la foto de mis empleados,encapsulo a ese atributo con el get y set
        public byte[]  FotoUSuario { get; set; }
        
    }
}
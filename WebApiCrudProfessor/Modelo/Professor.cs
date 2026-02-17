using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApiCrudProfessor.Modelo
{
    public class Professor
    {
        public int Id { get; init; }
        [StringLength(100)]
        public string Nome { get; set; } = null!;
        public string Disciplina { get; set; } = null!;
        [JsonIgnore]
        public DateTime DataAdmissao { get; private set; }
        [JsonIgnore]
        public bool Ativo { get; private set; }
        
        //criando agora 
        public void AtivarProfessor()
        {
            DataAdmissao = DateTime.Now;
            Ativo = true;
        }
    }
}
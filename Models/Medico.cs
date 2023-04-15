﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Medico
    {
        public int Codigo { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage ="Nome obrigatório")]
        [StringLength(200,ErrorMessage ="Nome não pode ser maior que 200 caracteres")]    

        public string Nome { get; set; }
       

        public DateTime? DataNascimento { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "CRM obrigatório")]
        [StringLength(9, ErrorMessage = "CRM não pode ser maior que 9 caracteres")]
        public string CRM { get; set; }


        public Medico()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.DataNascimento = null;
            this.CRM = "";
        }
    }
}
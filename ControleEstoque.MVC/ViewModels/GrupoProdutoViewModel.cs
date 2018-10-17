﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ControleEstoque.Domain.Entities;

namespace ControleEstoque.MVC.ViewModels
{
    public class GrupoProdutoViewModel
    {
        [Key]
        public int GrupoProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(150, ErrorMessage = "Descrição máximo 150 caracteres")]
        [MinLength(2, ErrorMessage = "Descrição mínimo 2 caracteres")]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }
    }
}
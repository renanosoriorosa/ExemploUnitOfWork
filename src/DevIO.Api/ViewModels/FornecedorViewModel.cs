﻿using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage ="O campo precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }

        public int TipoFornecedor { get; set; }
        public EnderecoViewModel Endereco { get; set; }

        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}

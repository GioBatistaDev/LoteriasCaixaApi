﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loterias.Util.Resources
{
    public class StringResources
    {
        public static string FormatarResource(string principal, params object[] args)
        {
            return string.Format(principal, args);
        }

        public static string FormatarResourceToLower(string principal, params string[] args)
        {
            if (args == null)
                return principal;

            return FormatarResource(principal, args.Select(x => x.ToLower()).ToArray());
        }

        public const string UrlBasePortalDeLoteriasCaixa = "https://servicebus2.caixa.gov.br/portaldeloterias/api/resultados";

        public const string ErroGenerico = "Não foi possível concluir a exportação dos dados da API da Caixa.";
        public const string MunicipioNaoInformado = "NÃO INFORMADO";
        public const string UfNaoInformado = "NI";
        public const string CanalEletronico = "CANAL ELETRONICO";
        public const string NomeDeUfInvalido1 = "--";
        public const string NomeDeUfInvalido2 = "XX";

        public const string UrlBaseIbge = "https://servicodados.ibge.gov.br/api/v1/";
        public const string UrlMunicipioIbge = "localidades/estados/{0}/municipios";
        public const string UrlUfIbge = "localidades/estados";
        public const string FalhaNaComunicacaoComApi = "Não foi possível estabelecer uma comunicação com a API do IBGE.";
        public const string CodigoIbgeDaUfInvalido = "O Código IBGE informado é inválido.";
    }
}
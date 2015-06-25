using Fact.Faker.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact.Faker.BR
{
    public class ColorBR
    {
        public static string Name => COLORS_NAME.Rand();

        private static string[] COLORS_NAME =
        {
            "branco","branco fumaça","cinza médio","cinza claro","prata","cinza escuro","cinza","cinza fosco",
            "cinza ardósia claro","cinza ardósia","cinza ardósia escuro","branco floral","marfim","linho",
            "creme","pêssego","bege","amarelo claro","amarelo","ouro","dourado","dourado escuro","oliva","verde grama",
            "verde limão","lima","verde escuro","verde mar","verde pálido","verde claro","verde primavera",
            "verde primavera médio","água-marinha","ciano escuro","turquesa","turquesa médio","aqua","ciano","ciano claro",
            "azul celeste","azul pólvora","azul claro","azul céu","azul royal","azul","azul escuro","púrpura","lavanda",
            "violeta","ameixa","neve","rosa","rosa claro","magenta","salmão","coral claro","vermelho indiano",
            "castanho claro","trigo","madeira","laranja","laranja escuro","chocolate","salmão escuro","salmão claro",
            "coral","tomate","jambo","vermelho","tijolo","marrom claro","vermelho escuro","preto"
        };
    }
}

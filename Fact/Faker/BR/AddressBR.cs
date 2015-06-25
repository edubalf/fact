using Fact.Faker.Utils;

namespace Fact.Faker.BR
{
    public class AddressBR
    {
        public static string City => CITIES.Rand();
        public static string State => STATES.Rand();
        public static string StateAbbr => STATES_ABBR.Rand();
        public static string ZipCode => "#####-###".Numerify();
        public static string StreetPrefix => "Rua Avenida Travessa Alameda".Rand();

        public static string Street
        {
            get
            {
                switch (2.Randomize())
                {
                    case 0: return string.Format("{0} {1}", StreetPrefix, NameBR.Name);
                    case 1: return string.Format("{0} {1} {2} {3}", StreetPrefix, NameBR.FirstName, NameBR.LasttName, NameBR.LasttName);
                    default: return string.Empty;
                }
            }
        }

        public static string Address
        {
            get
            {
                return string.Format("{0}, {1} - {2} - {3} / {4} - {5}", 
                    Street, 
                    "###".Numerify(), 
                    NameBR.Name,
                    City, 
                    StateAbbr, 
                    ZipCode);
            }
        }

        private static string[] STATES_ABBR = { "AC", "AL", "AP", "AM", "BA",
            "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PR", "PB", "PA",
            "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SE", "SP", "TO" };


        private static string[] STATES = { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará",
            "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
            "Minas Gerais", "Paraná", "Paraíba", "Pará", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte",
            "Rio Grande do Sul", "Rondonia", "Roraima", "Santa Catarina", "Sergipe", "São Paulo", "Tocantins" };


        private static string[] CITIES = { "São Paulo", "Rio de Janeiro", "Salvador", "Brasília", "Fortaleza", "Belo Horizonte",
            "Manaus", "Curitiba", "Recife", "Porto Alegre", "Belém", "Goiânia", "Guarulhos", "Campinas", "São Luís", "São Gonçalo",
            "Maceió", "Duque de Caxias", "Natal", "Teresina", "Campo Grande", "São Bernardo do Campo", "Nova Iguaçu", "João Pessoa",
            "Santo André", "Osasco", "Jaboatão dos Guararapes", "São José dos Campos", "Ribeirão Preto", "Uberlândia", "Contagem",
            "Sorocaba", "Aracaju", "Feira de Santana", "Cuiabá", "Joinville", "Juiz de Fora", "Londrina", "Aparecida de Goiânia",
            "Niterói", "Ananindeua", "Porto Velho", "Belford Roxo", "Campos dos Goytacazes", "Serra", "Caxias do Sul",
            "São João de Meriti", "Vila Velha", "Florianópolis", "Mauá", "Macapá", "São José do Rio Preto", "Santos",
            "Mogi das Cruzes", "Diadema", "Betim", "Campina Grande", "Jundiaí", "Olinda", "Carapicuíba", "Montes Claros", "Maringá",
            "Piracicaba", "Cariacica", "Bauru", "Anápolis", "Rio Branco", "São Vicente", "Vitória", "Caucaia", "Itaquaquecetuba",
            "Pelotas", "Canoas", "Caruaru", "Vitória da Conquista", "Franca", "Ponta Grossa", "Blumenau", "Petrolina", "Paulista",
            "Ribeirão das Neves", "Uberaba", "Boa Vista", "Guarujá", "Cascavel", "Petrópolis", "Taubaté", "Limeira", "Santarém",
            "Praia Grande", "São José dos Pinhais", "Mossoró", "Suzano", "Camaçari", "Governador Valadares", "Santa Maria",
            "Gravataí", "Taboão da Serra", "Foz do Iguaçu", "Várzea Grande", "Volta Redonda", "Juazeiro do Norte", "Sumaré",
            "Palmas", "Barueri", "Embu das Artes", "Ipatinga", "Marabá", "Imperatriz", "Viamão", "Novo Hamburgo", "São Carlos",
            "Magé", "Parnamirim", "Marília", "Arapiraca", "Sete Lagoas", "Colombo", "Divinópolis", "São Leopoldo", "Itaboraí",
            "São José", "Americana", "Macaé", "Jacareí", "Indaiatuba", "Araraquara", "Cotia", "Presidente Prudente", "Itabuna",
            "Maracanaú", "Itapevi", "Juazeiro", "Santa Luzia", "Hortolândia", "Rondonópolis", "Dourados", "Rio Grande",
            "Cachoeiro de Itapemirim", "Alvorada", "Criciúma", "Cabo Frio", "Chapecó", "Itajaí", "Sobral", "Rio Verde",
            "Rio Claro", "Cabo de Santo Agostinho", "Passo Fundo", "Araçatuba", "Santa Bárbara do Oeste", "Luziânia", "Ilhéus",
            "Lauro de Freitas", "Nova Friburgo", "Castanhal", "Angra dos Reis", "Ferraz de Vasconcelos", "Barra Mansa",
            "Águas Lindas de Goiás", "Parauapebas", "Guarapuava", "Nossa Senhora do Socorro", "São José de Ribamar",
            "Mesquita", "Ibirité", "Teresópolis", "Francisco Morato", "Araguaína", "Itu", "Itapecerica da Serra",
            "Timon", "Jequié", "Poços de Caldas", "Caxias", "Lages", "Nilópolis", "Linhares", "Pindamonhangaba",
            "Bragança Paulista", "Jaraguá do Sul", "São Caetano do Sul", "Itapetininga", "Teixeira de Freitas",
            "Alagoinhas", "Camaragibe", "Barreiras", "Palhoça", "Parnaíba", "Paranaguá", "Abaetetuba", "Valparaíso de Goiás",
            "Patos de Minas", "Mogi Guaçu", "Franco da Rocha", "Queimados", "Porto Seguro", "Pouso Alegre", "Jaú", "Teófilo Otoni",
            "Maricá", "Sapucaia do Sul", "Botucatu", "Garanhuns", "Atibaia", "Vitória de Santo Antão", "Barbacena", "Sabará",
            "Varginha", "Simões Filho", "Uruguaiana", "Araucária", "Toledo", "Ji-Paraná", "Apucarana", "Cametá", "Crato", "Araras",
            "Santa Rita", "Cubatão", "Santa Cruz do Sul", "Pinhais", "Cachoeirinha", "Sinop", "Resende", "Conselheiro Lafaiete",
            "Itapipoca", "Rio das Ostras", "Bagé", "Santana de Parnaíba", "Balneário Camboriú", "Campo Largo", "São Mateus",
            "Colatina", "Maranguape", "Codó", "Araruama", "Ribeirão Pires", "Bragança", "Catanduva", "Barretos", "Guaratinguetá",
            "Marituba", "Sertãozinho", "Paulo Afonso", "Brusque", "Valinhos", "Guarapari", "Jandira", "Birigui", "Itabira",
            "Votorantim", "Itaguaí", "Araguari", "Vespasiano", "Tatuí", "Várzea Paulista", "Trindade", "Paço do Lumiar",
            "Arapongas", "Salto", "Poá", "Passos", "Bento Gonçalves", "Eunápolis", "Almirante Tamandaré", "Barcarena", "Itatiba",
            "Caraguatatuba", "Três Lagoas", "Igarassu", "Parintins", "Santana", "Ourinhos", "Formosa", "Ubá", "Coronel Fabriciano",
            "São Lourenço da Mata", "Açailândia", "Corumbá", "São Félix do Xingu", "Umuarama", "Muriaé", "Altamira", "Patos",
            "Paragominas", "Tucuruí", "Novo Gama", "Bayeux", "Cambé", "Ituiutaba", "Bacabal", "Tubarão", "Ariquemes", "Erechim",
            "Piraquara", "Lagarto", "Assis", "Iguatu" };

    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Confitec.TestePratico.Infra.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataNascimento", "Email", "Escolaridade", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { 1, new DateTime(2011, 7, 6, 0, 24, 4, 635, DateTimeKind.Local).AddTicks(673), "caua_costa68@yahoo.com", 3, "Maria Alice", "Batista" },
                    { 128, new DateTime(2006, 12, 29, 9, 17, 24, 800, DateTimeKind.Local).AddTicks(5801), "bryan.albuquerque94@gmail.com", 3, "Heloísa", "Albuquerque" },
                    { 129, new DateTime(2005, 7, 27, 23, 41, 40, 63, DateTimeKind.Local).AddTicks(5881), "caua76@hotmail.com", 4, "Hugo", "Carvalho" },
                    { 130, new DateTime(2013, 3, 11, 14, 47, 44, 270, DateTimeKind.Local).AddTicks(5047), "anaclara_pereira@hotmail.com", 3, "Sophia", "Pereira" },
                    { 131, new DateTime(2014, 2, 27, 14, 50, 22, 140, DateTimeKind.Local).AddTicks(1460), "yango.albuquerque@yahoo.com", 4, "Ana Clara", "Carvalho" },
                    { 132, new DateTime(2016, 8, 10, 15, 12, 46, 85, DateTimeKind.Local).AddTicks(4712), "yago_carvalho17@gmail.com", 3, "Ana Clara", "Albuquerque" },
                    { 133, new DateTime(2016, 4, 3, 14, 0, 27, 537, DateTimeKind.Local).AddTicks(6961), "anthony.carvalho@gmail.com", 2, "Cauã", "Reis" },
                    { 134, new DateTime(2020, 1, 22, 0, 36, 47, 997, DateTimeKind.Local).AddTicks(1398), "luiza_moreira43@hotmail.com", 2, "Alessandro", "Oliveira" },
                    { 135, new DateTime(2005, 11, 3, 19, 35, 7, 195, DateTimeKind.Local).AddTicks(5442), "rafaela_moraes@gmail.com", 4, "Théo", "Costa" },
                    { 136, new DateTime(2011, 6, 23, 20, 44, 57, 156, DateTimeKind.Local).AddTicks(9846), "leonardo.oliveira78@yahoo.com", 4, "Yango", "Batista" },
                    { 137, new DateTime(2018, 2, 24, 0, 13, 13, 235, DateTimeKind.Local).AddTicks(1858), "eloa64@bol.com.br", 3, "Isabela", "Saraiva" },
                    { 138, new DateTime(2003, 9, 26, 5, 53, 3, 959, DateTimeKind.Local).AddTicks(9296), "rebeca.carvalho@bol.com.br", 4, "Júlia", "Reis" },
                    { 139, new DateTime(2005, 3, 4, 10, 51, 29, 687, DateTimeKind.Local).AddTicks(8934), "antonio29@live.com", 4, "Tertuliano", "Saraiva" },
                    { 140, new DateTime(2006, 12, 7, 1, 8, 55, 546, DateTimeKind.Local).AddTicks(8124), "felipe51@live.com", 2, "Maria Eduarda", "Souza" },
                    { 141, new DateTime(2012, 3, 10, 17, 30, 7, 515, DateTimeKind.Local).AddTicks(4831), "frederico43@hotmail.com", 3, "Maria Cecília", "Melo" },
                    { 142, new DateTime(2016, 5, 29, 10, 27, 24, 689, DateTimeKind.Local).AddTicks(2519), "nubia.moraes16@gmail.com", 3, "Maria Clara", "Martins" },
                    { 143, new DateTime(2001, 12, 26, 18, 37, 50, 425, DateTimeKind.Local).AddTicks(5883), "eduardo_moreira@hotmail.com", 2, "Roberta", "Carvalho" },
                    { 144, new DateTime(2010, 3, 22, 9, 43, 53, 843, DateTimeKind.Local).AddTicks(4120), "marcela.saraiva@yahoo.com", 3, "Vicente", "Macedo" },
                    { 145, new DateTime(2002, 12, 3, 0, 14, 13, 343, DateTimeKind.Local).AddTicks(3945), "benjamin.carvalho@hotmail.com", 1, "Sara", "Oliveira" },
                    { 146, new DateTime(2012, 11, 6, 15, 2, 42, 206, DateTimeKind.Local).AddTicks(9577), "larissa47@live.com", 3, "Leonardo", "Martins" },
                    { 147, new DateTime(2010, 3, 15, 23, 23, 16, 602, DateTimeKind.Local).AddTicks(5530), "vitor_silva@gmail.com", 2, "Cecília", "Xavier" },
                    { 148, new DateTime(2016, 12, 24, 11, 17, 33, 275, DateTimeKind.Local).AddTicks(4641), "sirineu.nogueira@hotmail.com", 2, "Júlio César", "Barros" },
                    { 127, new DateTime(2003, 11, 4, 12, 2, 59, 195, DateTimeKind.Local).AddTicks(918), "sophia.albuquerque60@bol.com.br", 2, "Benício", "Martins" },
                    { 149, new DateTime(2005, 7, 28, 7, 0, 7, 915, DateTimeKind.Local).AddTicks(5106), "norberto.saraiva@live.com", 2, "Hélio", "Albuquerque" },
                    { 126, new DateTime(2004, 6, 27, 1, 49, 41, 486, DateTimeKind.Local).AddTicks(2349), "mercia.saraiva@bol.com.br", 3, "Yasmin", "Moraes" },
                    { 124, new DateTime(2019, 2, 7, 15, 15, 26, 237, DateTimeKind.Local).AddTicks(803), "isabella_batista@live.com", 4, "Júlio", "Melo" },
                    { 103, new DateTime(2015, 10, 1, 5, 27, 30, 473, DateTimeKind.Local).AddTicks(7983), "vitor_saraiva@yahoo.com", 3, "Alícia", "Barros" },
                    { 104, new DateTime(2013, 3, 3, 6, 34, 11, 159, DateTimeKind.Local).AddTicks(8570), "cecilia.souza@bol.com.br", 1, "Lara", "Albuquerque" },
                    { 105, new DateTime(2015, 8, 8, 15, 25, 22, 59, DateTimeKind.Local).AddTicks(2728), "lucas.batista83@gmail.com", 3, "Arthur", "Santos" },
                    { 106, new DateTime(2007, 11, 14, 19, 22, 11, 629, DateTimeKind.Local).AddTicks(1735), "yasmin.franco@hotmail.com", 2, "Paula", "Souza" },
                    { 107, new DateTime(2019, 5, 20, 15, 30, 7, 666, DateTimeKind.Local).AddTicks(5595), "isaac20@live.com", 2, "Júlio", "Carvalho" },
                    { 108, new DateTime(2004, 12, 2, 22, 46, 26, 319, DateTimeKind.Local).AddTicks(4333), "felix_reis34@hotmail.com", 1, "Hélio", "Braga" },
                    { 109, new DateTime(2002, 1, 20, 12, 44, 35, 532, DateTimeKind.Local).AddTicks(6396), "breno.franco@live.com", 4, "Heitor", "Moraes" },
                    { 110, new DateTime(2020, 5, 1, 16, 26, 42, 272, DateTimeKind.Local).AddTicks(5873), "pedrohenrique47@yahoo.com", 3, "Luiza", "Nogueira" },
                    { 111, new DateTime(2005, 5, 7, 8, 20, 40, 310, DateTimeKind.Local).AddTicks(8180), "yasmin18@live.com", 2, "Deneval", "Souza" },
                    { 112, new DateTime(2008, 6, 5, 17, 13, 7, 610, DateTimeKind.Local).AddTicks(1873), "analaura.moreira53@yahoo.com", 4, "Meire", "Pereira" },
                    { 113, new DateTime(2015, 6, 24, 19, 13, 22, 81, DateTimeKind.Local).AddTicks(9052), "esther_costa@yahoo.com", 1, "Júlio César", "Albuquerque" },
                    { 114, new DateTime(2019, 9, 11, 10, 38, 49, 599, DateTimeKind.Local).AddTicks(661), "larissa_moraes@gmail.com", 2, "Márcia", "Albuquerque" },
                    { 115, new DateTime(2012, 5, 6, 15, 5, 5, 69, DateTimeKind.Local).AddTicks(8600), "warley50@live.com", 3, "Samuel", "Melo" },
                    { 116, new DateTime(2010, 2, 19, 20, 5, 59, 581, DateTimeKind.Local).AddTicks(3251), "analuiza_franco@gmail.com", 1, "Ana Laura", "Carvalho" },
                    { 117, new DateTime(2016, 7, 28, 22, 35, 18, 568, DateTimeKind.Local).AddTicks(9571), "yuri_xavier@bol.com.br", 4, "Henrique", "Costa" },
                    { 118, new DateTime(2011, 5, 9, 15, 27, 49, 588, DateTimeKind.Local).AddTicks(260), "janaina87@yahoo.com", 3, "Antonella", "Silva" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataNascimento", "Email", "Escolaridade", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { 119, new DateTime(2014, 1, 16, 11, 28, 23, 800, DateTimeKind.Local).AddTicks(7775), "manuela.moreira@yahoo.com", 2, "Ana Clara", "Souza" },
                    { 120, new DateTime(2007, 4, 16, 3, 23, 14, 761, DateTimeKind.Local).AddTicks(5628), "elisa.martins@hotmail.com", 4, "Sophia", "Moraes" },
                    { 121, new DateTime(2019, 7, 31, 17, 0, 54, 791, DateTimeKind.Local).AddTicks(9658), "gubio76@bol.com.br", 4, "Larissa", "Saraiva" },
                    { 122, new DateTime(2003, 10, 10, 2, 5, 54, 540, DateTimeKind.Local).AddTicks(8028), "yasmin31@gmail.com", 3, "Feliciano", "Macedo" },
                    { 123, new DateTime(2012, 6, 30, 7, 35, 11, 564, DateTimeKind.Local).AddTicks(8297), "analuiza74@live.com", 2, "Rebeca", "Macedo" },
                    { 125, new DateTime(2008, 5, 11, 7, 11, 15, 814, DateTimeKind.Local).AddTicks(2848), "gabriel_souza54@yahoo.com", 3, "Lorraine", "Franco" },
                    { 102, new DateTime(2017, 1, 28, 5, 49, 24, 664, DateTimeKind.Local).AddTicks(9303), "dalila_macedo56@live.com", 2, "Nataniel", "Martins" },
                    { 150, new DateTime(2003, 1, 6, 18, 45, 29, 469, DateTimeKind.Local).AddTicks(3294), "mariaeduarda53@yahoo.com", 2, "Leonardo", "Reis" },
                    { 152, new DateTime(2004, 5, 1, 14, 51, 17, 221, DateTimeKind.Local).AddTicks(3710), "lucca_souza64@yahoo.com", 1, "Talita", "Batista" },
                    { 178, new DateTime(2010, 2, 10, 13, 36, 54, 105, DateTimeKind.Local).AddTicks(5067), "alessandra_pereira@gmail.com", 4, "Cecília", "Souza" },
                    { 179, new DateTime(2009, 12, 26, 11, 44, 2, 145, DateTimeKind.Local).AddTicks(6246), "marina.nogueira@hotmail.com", 2, "Antônio", "Carvalho" },
                    { 180, new DateTime(2011, 6, 2, 13, 23, 25, 998, DateTimeKind.Local).AddTicks(6701), "helio.carvalho@live.com", 2, "Rafael", "Costa" },
                    { 181, new DateTime(2006, 5, 25, 20, 50, 10, 558, DateTimeKind.Local).AddTicks(2196), "marcelo95@gmail.com", 4, "Danilo", "Saraiva" },
                    { 182, new DateTime(2005, 9, 18, 8, 38, 19, 657, DateTimeKind.Local).AddTicks(1776), "melissa_macedo@gmail.com", 4, "Paulo", "Moreira" },
                    { 183, new DateTime(2020, 1, 19, 20, 4, 39, 917, DateTimeKind.Local).AddTicks(7121), "felicia_moraes0@live.com", 1, "Dalila", "Moreira" },
                    { 184, new DateTime(2016, 6, 5, 18, 15, 56, 394, DateTimeKind.Local).AddTicks(5915), "marialuiza_barros@live.com", 4, "Melissa", "Oliveira" },
                    { 185, new DateTime(2013, 11, 30, 0, 33, 26, 915, DateTimeKind.Local).AddTicks(7954), "heloisa_melo75@hotmail.com", 1, "Isaac", "Pereira" },
                    { 186, new DateTime(2011, 3, 30, 7, 28, 49, 575, DateTimeKind.Local).AddTicks(3840), "lorenzo20@live.com", 3, "Rafael", "Braga" },
                    { 187, new DateTime(2018, 1, 13, 16, 32, 39, 909, DateTimeKind.Local).AddTicks(9313), "mariajulia40@bol.com.br", 3, "Gúbio", "Moraes" },
                    { 188, new DateTime(2015, 4, 8, 3, 45, 22, 950, DateTimeKind.Local).AddTicks(8146), "feliciano_costa@bol.com.br", 4, "Gustavo", "Pereira" },
                    { 189, new DateTime(2006, 10, 1, 15, 35, 7, 841, DateTimeKind.Local).AddTicks(7581), "joana17@yahoo.com", 4, "Laura", "Costa" },
                    { 190, new DateTime(2002, 5, 4, 13, 9, 37, 113, DateTimeKind.Local).AddTicks(6622), "aline_santos87@hotmail.com", 2, "Emanuelly", "Macedo" },
                    { 191, new DateTime(2021, 4, 16, 0, 14, 33, 286, DateTimeKind.Local).AddTicks(7766), "maria.moraes28@yahoo.com", 4, "Fabrícia", "Moraes" },
                    { 192, new DateTime(2005, 8, 9, 0, 24, 17, 63, DateTimeKind.Local).AddTicks(1565), "rebeca.franco@gmail.com", 4, "Maria Helena", "Moreira" },
                    { 193, new DateTime(2003, 3, 17, 13, 14, 52, 406, DateTimeKind.Local).AddTicks(2307), "alice26@yahoo.com", 4, "Silas", "Costa" },
                    { 194, new DateTime(2002, 5, 21, 3, 29, 29, 198, DateTimeKind.Local).AddTicks(5146), "manuela.nogueira@live.com", 2, "Carlos", "Carvalho" },
                    { 195, new DateTime(2012, 5, 19, 20, 47, 14, 980, DateTimeKind.Local).AddTicks(5487), "nicolas.macedo@hotmail.com", 1, "Samuel", "Moraes" },
                    { 196, new DateTime(2015, 11, 26, 4, 58, 4, 883, DateTimeKind.Local).AddTicks(8947), "yasmin.carvalho31@live.com", 3, "Margarida", "Melo" },
                    { 197, new DateTime(2012, 2, 11, 13, 28, 19, 206, DateTimeKind.Local).AddTicks(1146), "marcelo_oliveira94@bol.com.br", 1, "Matheus", "Albuquerque" },
                    { 198, new DateTime(2006, 11, 15, 3, 4, 46, 587, DateTimeKind.Local).AddTicks(2837), "felix.batista70@hotmail.com", 3, "Benício", "Saraiva" },
                    { 177, new DateTime(2021, 6, 1, 2, 35, 13, 144, DateTimeKind.Local).AddTicks(5895), "cesar_albuquerque81@bol.com.br", 1, "Larissa", "Santos" },
                    { 151, new DateTime(2018, 8, 19, 14, 10, 41, 200, DateTimeKind.Local).AddTicks(4508), "analuiza.oliveira@hotmail.com", 2, "Gabriel", "Xavier" },
                    { 176, new DateTime(2014, 1, 26, 9, 6, 53, 271, DateTimeKind.Local).AddTicks(1648), "alessandra_moreira28@gmail.com", 1, "Heloísa", "Martins" },
                    { 174, new DateTime(2018, 4, 18, 20, 1, 36, 484, DateTimeKind.Local).AddTicks(5550), "benicio_moraes@live.com", 2, "Bernardo", "Souza" },
                    { 153, new DateTime(2004, 9, 18, 1, 4, 21, 815, DateTimeKind.Local).AddTicks(453), "benjamin_silva94@live.com", 4, "Kléber", "Costa" },
                    { 154, new DateTime(2004, 2, 19, 4, 49, 0, 446, DateTimeKind.Local).AddTicks(8937), "joaopedro_xavier35@bol.com.br", 1, "Laura", "Macedo" },
                    { 155, new DateTime(2013, 8, 2, 3, 12, 48, 390, DateTimeKind.Local).AddTicks(2221), "alessandra.braga@hotmail.com", 3, "João Lucas", "Barros" },
                    { 156, new DateTime(2016, 4, 27, 21, 57, 32, 6, DateTimeKind.Local).AddTicks(6903), "nubia_batista@live.com", 1, "Arthur", "Melo" },
                    { 157, new DateTime(2015, 1, 29, 17, 33, 34, 249, DateTimeKind.Local).AddTicks(5183), "fabiano_albuquerque21@gmail.com", 3, "Suélen", "Oliveira" },
                    { 158, new DateTime(2003, 1, 14, 10, 31, 5, 565, DateTimeKind.Local).AddTicks(3639), "norberto_carvalho53@bol.com.br", 4, "Caio", "Oliveira" },
                    { 159, new DateTime(2019, 9, 22, 23, 43, 33, 934, DateTimeKind.Local).AddTicks(4116), "joaopedro51@gmail.com", 2, "Breno", "Saraiva" },
                    { 160, new DateTime(2019, 1, 8, 8, 20, 21, 686, DateTimeKind.Local).AddTicks(2990), "julio.reis66@gmail.com", 3, "Marina", "Costa" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataNascimento", "Email", "Escolaridade", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { 161, new DateTime(2002, 12, 28, 15, 30, 17, 553, DateTimeKind.Local).AddTicks(3277), "marcela.souza@hotmail.com", 2, "Isaac", "Carvalho" },
                    { 162, new DateTime(2019, 10, 29, 23, 7, 39, 2, DateTimeKind.Local).AddTicks(9402), "mercia.xavier@yahoo.com", 2, "Antônio", "Costa" },
                    { 163, new DateTime(2020, 4, 23, 12, 8, 25, 920, DateTimeKind.Local).AddTicks(8740), "antonella_martins@live.com", 1, "Lívia", "Macedo" },
                    { 164, new DateTime(2021, 3, 16, 16, 26, 3, 128, DateTimeKind.Local).AddTicks(8563), "vitor.oliveira31@hotmail.com", 2, "Warley", "Moreira" },
                    { 165, new DateTime(2019, 9, 7, 18, 9, 22, 206, DateTimeKind.Local).AddTicks(6600), "giovanna.reis95@hotmail.com", 2, "Antônio", "Albuquerque" },
                    { 166, new DateTime(2004, 12, 8, 13, 14, 46, 93, DateTimeKind.Local).AddTicks(4920), "alexandre9@bol.com.br", 3, "Breno", "Souza" },
                    { 167, new DateTime(2021, 6, 26, 10, 3, 56, 355, DateTimeKind.Local).AddTicks(7235), "emanuelly_martins@yahoo.com", 3, "Maria Clara", "Melo" },
                    { 168, new DateTime(2010, 12, 24, 13, 36, 47, 866, DateTimeKind.Local).AddTicks(8741), "maria31@gmail.com", 3, "Paula", "Souza" },
                    { 169, new DateTime(2021, 6, 14, 16, 39, 36, 338, DateTimeKind.Local).AddTicks(5619), "lorenzo_carvalho@yahoo.com", 2, "Ricardo", "Batista" },
                    { 170, new DateTime(2005, 11, 15, 15, 15, 32, 430, DateTimeKind.Local).AddTicks(7925), "aline.oliveira@hotmail.com", 3, "Danilo", "Saraiva" },
                    { 171, new DateTime(2017, 2, 21, 7, 45, 38, 476, DateTimeKind.Local).AddTicks(170), "paula83@live.com", 2, "Pedro", "Saraiva" },
                    { 172, new DateTime(2002, 5, 3, 2, 8, 26, 808, DateTimeKind.Local).AddTicks(9800), "breno_batista@yahoo.com", 2, "Washington", "Nogueira" },
                    { 173, new DateTime(2009, 3, 8, 14, 11, 54, 629, DateTimeKind.Local).AddTicks(872), "benicio45@hotmail.com", 4, "Raul", "Pereira" },
                    { 175, new DateTime(2016, 9, 9, 15, 2, 16, 640, DateTimeKind.Local).AddTicks(2726), "hugo.batista@hotmail.com", 2, "Marli", "Carvalho" },
                    { 101, new DateTime(2015, 5, 3, 23, 52, 17, 350, DateTimeKind.Local).AddTicks(3573), "gubio94@hotmail.com", 4, "Marina", "Saraiva" },
                    { 100, new DateTime(2021, 5, 1, 20, 33, 10, 83, DateTimeKind.Local).AddTicks(7362), "isabella8@bol.com.br", 1, "Antonella", "Souza" },
                    { 99, new DateTime(2021, 8, 10, 9, 44, 54, 525, DateTimeKind.Local).AddTicks(6573), "gabriel91@hotmail.com", 3, "Davi", "Macedo" },
                    { 27, new DateTime(2007, 12, 12, 18, 40, 55, 278, DateTimeKind.Local).AddTicks(6530), "pedrohenrique95@bol.com.br", 4, "Samuel", "Moreira" },
                    { 28, new DateTime(2010, 9, 16, 14, 46, 41, 695, DateTimeKind.Local).AddTicks(4988), "pablo.nogueira@hotmail.com", 2, "Benício", "Nogueira" },
                    { 29, new DateTime(2009, 9, 7, 19, 26, 54, 165, DateTimeKind.Local).AddTicks(4272), "carlos_macedo@bol.com.br", 1, "Alessandra", "Nogueira" },
                    { 30, new DateTime(2014, 3, 1, 19, 19, 3, 306, DateTimeKind.Local).AddTicks(523), "anthony79@gmail.com", 4, "Norberto", "Martins" },
                    { 31, new DateTime(2018, 10, 14, 4, 20, 24, 571, DateTimeKind.Local).AddTicks(347), "anthony.nogueira56@hotmail.com", 2, "Márcia", "Moreira" },
                    { 32, new DateTime(2011, 8, 25, 5, 45, 36, 884, DateTimeKind.Local).AddTicks(2033), "silvia.franco80@hotmail.com", 1, "Daniel", "Barros" },
                    { 33, new DateTime(2002, 3, 28, 11, 57, 10, 599, DateTimeKind.Local).AddTicks(9139), "gustavo.silva98@bol.com.br", 1, "Maitê", "Martins" },
                    { 34, new DateTime(2018, 1, 30, 11, 24, 18, 14, DateTimeKind.Local).AddTicks(847), "roberto.moreira@hotmail.com", 3, "Fabrícia", "Reis" },
                    { 35, new DateTime(2017, 12, 21, 19, 31, 19, 497, DateTimeKind.Local).AddTicks(6300), "suelen.franco@yahoo.com", 3, "Pablo", "Xavier" },
                    { 36, new DateTime(2006, 3, 2, 15, 13, 9, 464, DateTimeKind.Local).AddTicks(8242), "lorena_albuquerque@bol.com.br", 2, "Miguel", "Silva" },
                    { 37, new DateTime(2009, 11, 20, 2, 50, 54, 201, DateTimeKind.Local).AddTicks(8215), "lorenzo88@bol.com.br", 2, "Eduarda", "Pereira" },
                    { 38, new DateTime(2016, 2, 26, 12, 36, 45, 641, DateTimeKind.Local).AddTicks(2069), "rebeca_souza@hotmail.com", 3, "Ladislau", "Barros" },
                    { 39, new DateTime(2008, 2, 23, 18, 46, 40, 985, DateTimeKind.Local).AddTicks(204), "gabriel.braga16@yahoo.com", 3, "Samuel", "Moreira" },
                    { 40, new DateTime(2009, 10, 31, 15, 56, 4, 743, DateTimeKind.Local).AddTicks(4329), "vicente92@hotmail.com", 2, "Júlia", "Santos" },
                    { 41, new DateTime(2014, 8, 12, 5, 46, 18, 823, DateTimeKind.Local).AddTicks(2180), "gael52@hotmail.com", 2, "Enzo", "Silva" },
                    { 42, new DateTime(2021, 3, 15, 1, 27, 19, 985, DateTimeKind.Local).AddTicks(8738), "eloa.martins@bol.com.br", 2, "Eloá", "Santos" },
                    { 43, new DateTime(2013, 10, 10, 0, 30, 0, 573, DateTimeKind.Local).AddTicks(7668), "lorenzo.reis65@gmail.com", 2, "Isabel", "Moreira" },
                    { 44, new DateTime(2006, 8, 11, 2, 22, 24, 312, DateTimeKind.Local).AddTicks(3367), "warley93@hotmail.com", 3, "Esther", "Macedo" },
                    { 45, new DateTime(2019, 7, 6, 0, 49, 0, 374, DateTimeKind.Local).AddTicks(8523), "alessandro.franco50@hotmail.com", 4, "Rebeca", "Melo" },
                    { 46, new DateTime(2015, 2, 27, 8, 3, 50, 609, DateTimeKind.Local).AddTicks(4286), "joaquim.franco79@yahoo.com", 2, "Vitória", "Pereira" },
                    { 47, new DateTime(2014, 4, 17, 18, 46, 8, 863, DateTimeKind.Local).AddTicks(645), "antonella89@gmail.com", 2, "Sophia", "Moraes" },
                    { 26, new DateTime(2012, 4, 17, 3, 40, 30, 434, DateTimeKind.Local).AddTicks(4984), "isabela_oliveira98@yahoo.com", 3, "Bruna", "Silva" },
                    { 48, new DateTime(2007, 4, 11, 1, 58, 44, 764, DateTimeKind.Local).AddTicks(3427), "morgana.oliveira78@live.com", 1, "Fábio", "Pereira" },
                    { 25, new DateTime(2003, 11, 27, 11, 26, 21, 299, DateTimeKind.Local).AddTicks(9901), "murilo66@yahoo.com", 1, "Sara", "Carvalho" },
                    { 23, new DateTime(2016, 3, 12, 9, 22, 0, 539, DateTimeKind.Local).AddTicks(9370), "helio19@yahoo.com", 2, "Emanuelly", "Franco" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataNascimento", "Email", "Escolaridade", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { 2, new DateTime(2003, 8, 14, 17, 31, 39, 826, DateTimeKind.Local).AddTicks(8279), "melissa.saraiva@yahoo.com", 3, "Miguel", "Macedo" },
                    { 3, new DateTime(2014, 9, 6, 11, 0, 32, 628, DateTimeKind.Local).AddTicks(2371), "pablo_xavier@bol.com.br", 2, "Vitor", "Xavier" },
                    { 4, new DateTime(2020, 8, 10, 13, 39, 55, 609, DateTimeKind.Local).AddTicks(4949), "tertuliano.franco61@gmail.com", 3, "Rafaela", "Saraiva" },
                    { 5, new DateTime(2012, 6, 7, 12, 51, 45, 701, DateTimeKind.Local).AddTicks(5893), "pietro.braga@hotmail.com", 3, "Anthony", "Franco" },
                    { 6, new DateTime(2020, 11, 23, 5, 2, 19, 633, DateTimeKind.Local).AddTicks(8875), "liz.carvalho@yahoo.com", 4, "Mariana", "Pereira" },
                    { 7, new DateTime(2013, 8, 31, 20, 30, 28, 444, DateTimeKind.Local).AddTicks(4958), "kleber49@bol.com.br", 3, "Ígor", "Santos" },
                    { 8, new DateTime(2016, 2, 18, 5, 6, 38, 567, DateTimeKind.Local).AddTicks(5093), "marialuiza69@hotmail.com", 4, "Ana Júlia", "Saraiva" },
                    { 9, new DateTime(2010, 8, 31, 17, 48, 22, 214, DateTimeKind.Local).AddTicks(7443), "mariahelena.santos30@bol.com.br", 4, "Ricardo", "Macedo" },
                    { 10, new DateTime(2010, 8, 14, 11, 32, 30, 247, DateTimeKind.Local).AddTicks(2556), "karla_costa18@yahoo.com", 2, "Luiza", "Martins" },
                    { 11, new DateTime(2021, 5, 24, 11, 7, 49, 175, DateTimeKind.Local).AddTicks(8908), "marcia.silva47@live.com", 2, "Sarah", "Costa" },
                    { 12, new DateTime(2018, 12, 4, 22, 32, 37, 21, DateTimeKind.Local).AddTicks(8899), "paula_barros@hotmail.com", 4, "Hélio", "Carvalho" },
                    { 13, new DateTime(2013, 7, 18, 16, 9, 44, 439, DateTimeKind.Local).AddTicks(8902), "giovanna.pereira59@live.com", 2, "Talita", "Carvalho" },
                    { 14, new DateTime(2018, 12, 27, 13, 40, 59, 352, DateTimeKind.Local).AddTicks(7642), "mariaclara83@live.com", 4, "Enzo", "Macedo" },
                    { 15, new DateTime(2004, 8, 25, 19, 0, 23, 117, DateTimeKind.Local).AddTicks(3115), "liz58@live.com", 2, "Vitória", "Souza" },
                    { 16, new DateTime(2021, 2, 4, 8, 28, 28, 31, DateTimeKind.Local).AddTicks(9890), "alexandre1@bol.com.br", 4, "Esther", "Carvalho" },
                    { 17, new DateTime(2016, 7, 31, 13, 19, 31, 297, DateTimeKind.Local).AddTicks(9815), "nubia_silva8@bol.com.br", 2, "Júlio César", "Carvalho" },
                    { 18, new DateTime(2009, 5, 7, 13, 43, 42, 501, DateTimeKind.Local).AddTicks(3968), "victor39@hotmail.com", 4, "Matheus", "Pereira" },
                    { 19, new DateTime(2007, 8, 12, 23, 38, 6, 886, DateTimeKind.Local).AddTicks(7691), "antonio0@yahoo.com", 3, "Tertuliano", "Carvalho" },
                    { 20, new DateTime(2020, 3, 24, 19, 21, 18, 615, DateTimeKind.Local).AddTicks(3567), "emanuelly.moreira77@live.com", 3, "Maria Eduarda", "Martins" },
                    { 21, new DateTime(2018, 4, 3, 1, 29, 11, 186, DateTimeKind.Local).AddTicks(7148), "marli_nogueira46@hotmail.com", 3, "Meire", "Melo" },
                    { 22, new DateTime(2008, 12, 8, 18, 24, 30, 38, DateTimeKind.Local).AddTicks(7060), "vitoria.silva57@live.com", 2, "Célia", "Souza" },
                    { 24, new DateTime(2015, 10, 1, 2, 5, 37, 838, DateTimeKind.Local).AddTicks(4587), "noah_martins67@gmail.com", 4, "Lorena", "Nogueira" },
                    { 49, new DateTime(2010, 9, 14, 15, 57, 15, 659, DateTimeKind.Local).AddTicks(1871), "igor.batista96@hotmail.com", 4, "Karla", "Carvalho" },
                    { 50, new DateTime(2004, 2, 12, 11, 53, 4, 925, DateTimeKind.Local).AddTicks(912), "yago_melo@yahoo.com", 1, "Leonardo", "Pereira" },
                    { 51, new DateTime(2010, 1, 12, 10, 33, 47, 468, DateTimeKind.Local).AddTicks(925), "livia_barros43@hotmail.com", 1, "Samuel", "Nogueira" },
                    { 78, new DateTime(2019, 9, 14, 9, 33, 57, 299, DateTimeKind.Local).AddTicks(6562), "yago.carvalho@gmail.com", 3, "Isis", "Macedo" },
                    { 79, new DateTime(2002, 6, 12, 7, 17, 28, 677, DateTimeKind.Local).AddTicks(5359), "marli.carvalho@yahoo.com", 1, "Fabiano", "Reis" },
                    { 80, new DateTime(2003, 11, 26, 5, 11, 21, 114, DateTimeKind.Local).AddTicks(4071), "manuela51@gmail.com", 4, "Calebe", "Melo" },
                    { 81, new DateTime(2006, 3, 1, 13, 45, 15, 817, DateTimeKind.Local).AddTicks(2213), "alice_carvalho@yahoo.com", 3, "Margarida", "Martins" },
                    { 82, new DateTime(2012, 3, 4, 17, 57, 35, 699, DateTimeKind.Local).AddTicks(9945), "nubia_nogueira@bol.com.br", 3, "Vicente", "Macedo" },
                    { 83, new DateTime(2020, 12, 28, 21, 59, 18, 872, DateTimeKind.Local).AddTicks(4013), "alessandro99@live.com", 1, "Ígor", "Braga" },
                    { 84, new DateTime(2012, 11, 9, 11, 20, 56, 778, DateTimeKind.Local).AddTicks(1524), "lorenzo_costa1@gmail.com", 1, "César", "Melo" },
                    { 85, new DateTime(2015, 6, 15, 17, 1, 15, 633, DateTimeKind.Local).AddTicks(4629), "felicia_batista96@live.com", 3, "Larissa", "Pereira" },
                    { 86, new DateTime(2013, 11, 29, 2, 3, 4, 300, DateTimeKind.Local).AddTicks(4486), "nubia_xavier30@bol.com.br", 3, "Danilo", "Costa" },
                    { 87, new DateTime(2011, 6, 20, 7, 34, 32, 211, DateTimeKind.Local).AddTicks(8185), "paula.reis81@live.com", 4, "Pietro", "Xavier" },
                    { 88, new DateTime(2006, 11, 19, 15, 30, 8, 346, DateTimeKind.Local).AddTicks(3417), "melissa_santos@bol.com.br", 3, "Pietro", "Barros" },
                    { 89, new DateTime(2021, 3, 5, 22, 35, 36, 163, DateTimeKind.Local).AddTicks(3291), "davilucca_franco36@live.com", 3, "Mércia", "Macedo" },
                    { 90, new DateTime(2013, 11, 8, 3, 7, 2, 170, DateTimeKind.Local).AddTicks(403), "davilucca_moreira@yahoo.com", 1, "Ricardo", "Carvalho" },
                    { 91, new DateTime(2009, 1, 13, 13, 42, 32, 802, DateTimeKind.Local).AddTicks(3876), "silvia46@hotmail.com", 1, "Célia", "Santos" },
                    { 92, new DateTime(2019, 8, 21, 1, 1, 58, 774, DateTimeKind.Local).AddTicks(8214), "isabelly46@live.com", 3, "Meire", "Pereira" },
                    { 93, new DateTime(2007, 4, 11, 5, 26, 56, 236, DateTimeKind.Local).AddTicks(6777), "anaclara_franco@gmail.com", 4, "Ofélia", "Nogueira" },
                    { 94, new DateTime(2009, 1, 5, 18, 22, 45, 796, DateTimeKind.Local).AddTicks(4126), "livia14@gmail.com", 3, "Eduardo", "Reis" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataNascimento", "Email", "Escolaridade", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { 95, new DateTime(2017, 12, 23, 22, 5, 11, 886, DateTimeKind.Local).AddTicks(5337), "daniel94@live.com", 2, "Roberta", "Barros" },
                    { 96, new DateTime(2005, 10, 16, 8, 3, 5, 395, DateTimeKind.Local).AddTicks(5065), "bryan_silva14@yahoo.com", 1, "Meire", "Batista" },
                    { 97, new DateTime(2006, 8, 13, 12, 28, 59, 220, DateTimeKind.Local).AddTicks(6768), "salvador.moraes@yahoo.com", 2, "Arthur", "Batista" },
                    { 98, new DateTime(2009, 7, 2, 18, 46, 8, 842, DateTimeKind.Local).AddTicks(8315), "isis_pereira80@hotmail.com", 4, "Ana Luiza", "Carvalho" },
                    { 77, new DateTime(2020, 5, 23, 22, 39, 6, 903, DateTimeKind.Local).AddTicks(6967), "laura_silva86@live.com", 4, "Maria Clara", "Pereira" },
                    { 76, new DateTime(2003, 2, 22, 18, 38, 38, 875, DateTimeKind.Local).AddTicks(6411), "enzo.nogueira@gmail.com", 4, "Fabrício", "Reis" },
                    { 75, new DateTime(2004, 8, 21, 23, 22, 19, 284, DateTimeKind.Local).AddTicks(2616), "eloa90@yahoo.com", 2, "Elisa", "Braga" },
                    { 74, new DateTime(2009, 9, 17, 11, 37, 9, 779, DateTimeKind.Local).AddTicks(9497), "livia46@bol.com.br", 4, "Emanuel", "Xavier" },
                    { 52, new DateTime(2004, 2, 13, 2, 14, 56, 286, DateTimeKind.Local).AddTicks(296), "mariaalice57@yahoo.com", 2, "Ana Júlia", "Batista" },
                    { 53, new DateTime(2005, 2, 14, 7, 47, 49, 729, DateTimeKind.Local).AddTicks(9365), "cesar.barros@gmail.com", 4, "Aline", "Costa" },
                    { 54, new DateTime(2010, 9, 14, 3, 26, 24, 142, DateTimeKind.Local).AddTicks(8808), "marina.batista@live.com", 2, "Frederico", "Reis" },
                    { 55, new DateTime(2020, 8, 7, 15, 44, 45, 873, DateTimeKind.Local).AddTicks(1759), "enzo_reis@bol.com.br", 2, "Washington", "Xavier" },
                    { 56, new DateTime(2019, 2, 10, 17, 15, 54, 932, DateTimeKind.Local).AddTicks(2908), "pedrohenrique3@live.com", 3, "Yuri", "Moreira" },
                    { 57, new DateTime(2013, 4, 20, 18, 42, 59, 373, DateTimeKind.Local).AddTicks(1710), "mercia.oliveira88@hotmail.com", 1, "Isadora", "Reis" },
                    { 58, new DateTime(2005, 7, 20, 3, 8, 48, 604, DateTimeKind.Local).AddTicks(9213), "livia.martins63@hotmail.com", 1, "Miguel", "Braga" },
                    { 59, new DateTime(2009, 8, 8, 16, 18, 21, 455, DateTimeKind.Local).AddTicks(7065), "mariana45@live.com", 3, "Márcia", "Franco" },
                    { 60, new DateTime(2010, 6, 1, 9, 35, 47, 200, DateTimeKind.Local).AddTicks(8075), "lorraine.martins@live.com", 2, "Pietro", "Saraiva" },
                    { 61, new DateTime(2019, 9, 7, 14, 6, 6, 677, DateTimeKind.Local).AddTicks(4053), "joaquim_saraiva@bol.com.br", 2, "Larissa", "Barros" },
                    { 199, new DateTime(2015, 10, 28, 19, 36, 10, 592, DateTimeKind.Local).AddTicks(1527), "analuiza43@bol.com.br", 1, "Esther", "Batista" },
                    { 62, new DateTime(2007, 5, 17, 8, 18, 44, 111, DateTimeKind.Local).AddTicks(848), "livia.albuquerque10@gmail.com", 1, "Beatriz", "Reis" },
                    { 64, new DateTime(2011, 4, 19, 14, 7, 50, 673, DateTimeKind.Local).AddTicks(1394), "analaura_macedo@gmail.com", 2, "Sophia", "Macedo" },
                    { 65, new DateTime(2019, 1, 4, 20, 41, 50, 945, DateTimeKind.Local).AddTicks(9792), "paula37@yahoo.com", 1, "Yango", "Oliveira" },
                    { 66, new DateTime(2019, 2, 20, 10, 13, 53, 452, DateTimeKind.Local).AddTicks(2149), "paulo.costa@yahoo.com", 1, "Alessandra", "Oliveira" },
                    { 67, new DateTime(2016, 12, 25, 9, 40, 31, 198, DateTimeKind.Local).AddTicks(3876), "esther_franco@gmail.com", 1, "Isabelly", "Nogueira" },
                    { 68, new DateTime(2016, 10, 13, 15, 55, 24, 993, DateTimeKind.Local).AddTicks(8421), "breno_martins30@hotmail.com", 1, "Laura", "Santos" },
                    { 69, new DateTime(2012, 9, 6, 1, 4, 45, 635, DateTimeKind.Local).AddTicks(6600), "analaura.oliveira@bol.com.br", 1, "Giovanna", "Barros" },
                    { 70, new DateTime(2003, 9, 20, 15, 7, 27, 882, DateTimeKind.Local).AddTicks(8688), "sarah.batista29@yahoo.com", 2, "Roberto", "Pereira" },
                    { 71, new DateTime(2004, 9, 15, 4, 46, 12, 814, DateTimeKind.Local).AddTicks(4678), "yago_reis6@hotmail.com", 3, "Luiza", "Barros" },
                    { 72, new DateTime(2020, 2, 25, 10, 56, 58, 278, DateTimeKind.Local).AddTicks(4168), "lorenzo_costa@hotmail.com", 3, "Warley", "Souza" },
                    { 73, new DateTime(2007, 11, 12, 8, 59, 47, 416, DateTimeKind.Local).AddTicks(4623), "karla92@hotmail.com", 3, "Elisa", "Reis" },
                    { 63, new DateTime(2005, 12, 24, 23, 12, 49, 717, DateTimeKind.Local).AddTicks(9479), "gael9@yahoo.com", 3, "Júlia", "Souza" },
                    { 200, new DateTime(2003, 11, 28, 22, 41, 26, 305, DateTimeKind.Local).AddTicks(6080), "marcelo53@live.com", 4, "Danilo", "Saraiva" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}

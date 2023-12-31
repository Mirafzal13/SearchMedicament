﻿using MedKomment.Data.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedKomment.Data
{
    public class AppDataInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Medicaments.Any())
                {
                    context.Medicaments.AddRange(new List<Medicament>()
                    {
                        new Medicament()
                        {
                            Name = "Цетрин",
                            Ingredients = "гипромеллоза, макрогол 6000, титана диоксид, тальк, сорбиновая кислота, полисорбат 80, диметикон",
                            Uses = "Внутрь, независимо от приема пищи, не разжевывая, таблетки запивают 200 мл воды. Взрослым – по 10 мг (1 таб.) 1 раз/сут или по 5 мг (1/2 таб.) 2 раза/сут. Детям старше 6 лет – по 5 мг (1/2 таб.) 2 раза/сут или по 10 мг (1 таб.) 1 раз/сут. У пациентов со сниженной функцией почек (КК 30-49 мл/мин) назначают 5 мг/сут (1/2 таб.), при тяжелой хронической почечной недостаточности (КК 10-30 мл/мин) – 5 мг/сут (1/2 таб.) через день.",
                            Warnings = "Симптомы (возникают при приеме однократной дозы 50 мг): сухость во рту, сонливость, задержка мочеиспускания, запоры, беспокойство, повышенная раздражительность. Лечение: промывание желудка, назначение симптоматических лекарственных средств. Специфического антидота не существует. Гемодиализ неэффективен.",
                            Establishment = "Dr. Reddy`s Laboratories LTD (Индия)"
                        },
                        new Medicament()
                        {
                            Name = "Назонекс",
                            Ingredients = "целлюлоза дисперсная (целлюлоза микрокристаллическая, обработанная кармеллозой натрия) - 20 мг, глицерол - 21 мг, лимонной кислоты моногидрат - 2 мг, натрия цитрата дигидрат - 2.8 мг, полисорбат 80 - 0.1 мг, бензалкония хлорид (в виде 50% раствора) - 0.2 мг, вода очищенная - 0.95 г",
                            Uses = "Препарат применяют интраназально. Лечение сезонного или круглогодичного аллергического ринита Взрослые (в т.ч. пациенты пожилого возраста) и подростки с 12 лет Рекомендуемая профилактическая и терапевтическая доза препарата составляет 2 ингаляции (по 50 мкг каждая) в каждую ноздрю 1 раз/сут (суммарная суточная доза - 200 мкг). По достижении лечебного эффекта для поддерживающей терапии возможно уменьшение дозы до 1 ингаляции в каждую ноздрю 1 раз/сут (суммарная суточная доза - 100 мкг).",
                            Warnings = "При длительном применении ГКС в высоких дозах или при одновременном использовании нескольких ГКС возможно угнетение гипоталамо-гипофизарно-надпочечниковой системы.",
                            Establishment = "SCHERING-PLOUGH LABO N.V. (Бельгия)"
                        },
                        new Medicament()
                        {
                            Name = "Эриус",
                            Ingredients = "опадрай голубой (лактозы моногидрат, гипромеллоза, титана диоксид, макрогол, лак алюминиевый голубой) - 6 мг; опадрай прозрачный (гипромеллоза, макрогол) - 0.6 мг, воск карнаубский - 0.005 мг, воск пчелиный белый - 0.005 мг",
                            Uses = "Для приема внутрь. Таблетку следует проглатывать целиком, не разжевывая, и запивать водой. Препарат желательно принимать регулярно в одно и то же время суток, независимо от времени приема пищи. Взрослым и подросткам от 12 лет - по 1 таблетке (5 мг) 1 раз/сут.",
                            Warnings = "Симптомы: прием дозы, превышающей рекомендованную в 5 раз, не приводил к появлению каких-либо симптомов. В ходе клинических исследований ежедневное применение у взрослых и подростков дезлоратадина в дозе до 20 мг в течение 14 дней не сопровождалось статистически или клинически значимыми изменениями со стороны сердечно-сосудистой системы.",
                            Establishment = "BAYER AO (Россия)"
                        },
                        new Medicament()
                        {
                            Name = "Кларитин",
                            Ingredients = "пропиленгликоль - 100 мг, глицерол - 100 мг, лимонной кислоты моногидрат - 9.6 мг (или лимонная кислота безводная - 8.78 мг), натрия бензоат - 1 мг, сахароза (гранулированная) - 600 мг, ароматизатор искусственный (персиковый) - 2.5 мг, вода очищенная - q.s. до 1 мл",
                            Uses = "Препарат назначают внутрь, независимо от приема пищи. Взрослым (в т.ч. пациентам пожилого возраста) и подросткам в возрасте старше 12 лет рекомендуется прием Кларитина в дозе 10 мг (1 таб. или 2 чайные ложки /10 мл/ сиропа) 1 раз/сут. Детям в возрасте от 2 до 12 лет дозу Кларитина рекомендуется назначать в зависимости от массы тела: при массе тела менее 30 кг - 5 мг (1/2 таб. или 1 чайная ложка /5 мл/ сиропа) 1 раз/сут, при массе тела 30 кг и более - 10 мг (1 таб. или 2 чайные ложки /10 мл/ сиропа) 1 раз/сут.",
                            Warnings = "Кларитин® не усиливает действие этанола (алкоголя) на ЦНС. При совместном приеме Кларитина с кетоконазолом, эритромицином или циметидином отмечалось повышение концентрации лоратадина в плазме, но это повышение не являлось клинически значимым, в т.ч. по данным ЭКГ.",
                            Establishment = "SCHERING-PLOUGH LABO N.V. (Бельгия)"
                        },
                        new Medicament()
                        {
                            Name = "Кестин",
                            Ingredients = "1.725 мг, макрогол 6000 - 0.575 мг, титана диоксид - 0.575 мг",
                            Uses = "При приеме внутрь разовая доза для взрослых составляет 10 мг, частота приема - 1 раз/сут.",
                            Warnings = "Беременность, период лактации, повышенная чувствительность к производным пиперидина.",
                            Establishment = "INDUSTRIAS FARMACEUTICAS ALMIRALL S.A. (Испания)"
                        },
                        new Medicament()
                        {
                            Name = "Тавегил",
                            Ingredients = "магния стеарат - 1.2 мг, повидон - 4 мг, тальк - 5 мг, крахмал кукурузный - 10.8 мг, лактозы моногидрат - 107.66 мг",
                            Uses = "Применяют внутрь, в/м и в/в. Дозу, способ и схему применения, длительность терапии определяют индивидуально, в зависимости от показаний, клинической ситуации, возраста пациента и лекарственной формы.",
                            Warnings = "Повышенная чувствительность к клемастину или другим антигистаминным препаратам сходной химической структуры; беременность, период грудного вскармливания; прием ингибиторов МАО, заболевания нижних дыхательных путей (в т.ч. бронхиальная астма), детский возраст - в зависимости от лекарственной формы.",
                            Establishment = "FAMAR ITALIA S.p.A. (Италия)"
                        },
                        new Medicament()
                        {
                            Name = "Лоратадин-Вертекс",
                            Ingredients = "лактозы моногидрат - 97.6 мг, целлюлоза микрокристаллическая - 28 мг, карбоксиметилкрахмал натрия (натрия крахмала гликолат, тип А) - 3 мг, кальция стеарат - 1.4 мг.",
                            Uses = "Сезонный и круглогодичный аллергический ринит, конъюнктивит, острая крапивница и отек Квинке, симптомы гистаминергий, вызванные применением гистаминолибератов (псевдоаллергические синдромы), аллергические реакции на укусы насекомых, комплексное лечение зудящих дерматозов (контактные аллергодерматиты, хронические экземы).",
                            Warnings = "Беременность, лактация, детский возраст до 2 лет, повышенная чувствительность к лоратадину.",
                            Establishment = "VERTEX AO (Россия)"
                        },
                        new Medicament()
                        {
                            Name = "Зодак",
                            Ingredients = "лактозы моногидрат, крахмал кукурузный, повидон 30, магния стеарат. Состав оболочки: гипромеллоза 2910/5, макрогол 6000, тальк, титана диоксид, эмульсия симетикона SE4.",
                            Uses = "Взрослым и детям в возрасте 6 лет и старше для облегчения: назальных и глазных симптомов круглогодичного (персистирующего) и сезонного (интермиттирующего) аллергического ринита и аллергического конъюнктивита - зуда, чиханья, заложенности носа, ринореи, слезотечения, гиперемии конъюнктивы;         симптомов хронической идиопатической крапивницы.",
                            Warnings = "повышенная чувствительность к цетиризину, гидроксизину или производным пиперазина, а также к другим компонентам препарата; терминальная стадия почечной недостаточности (КК <10 мл/мин); ",
                            Establishment = "ZENTIVA k.s. (Чешская Республика)"
                        },
                        new Medicament()
                        {
                            Name = "Аллегра",
                            Ingredients = "гипромеллоза Е-15 - 2.84 мг, гипромеллоза Е-5 - 1.89 мг, повидон - 0.51 мг, титана диоксид (Е171) - 2.025 мг, кремния диоксид коллоидный - 0.73 мг, макрогол 400 - 3.94 мг, краситель железа оксид (розовая смесь: смесь железа оксида красного (Е172) и титана диоксида (Е171)) - 0.025 мг, краситель железа оксид (желтая смесь: смесь железа оксида желтого (Е172) и титана диоксида (Е171)) - 0.040 мг.",
                            Uses = "сезонный аллергический ринит (для уменьшения симптомов) - таблетки 120 мг; хроническая идиопатическая крапивница (для уменьшения симптомов) - таблетки 180 мг.",
                            Warnings = "повышенная чувствительность к любому из компонентов препарата; беременность; период лактации; детский возраст до 12 лет.",
                            Establishment = "SANOFI WINTHROP INDUSTRIE (Франция)"
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}

﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using Core.Models.Ciphers;

namespace Core.Data
{
    public static class CiphersList
    {
        public static ObservableCollection<Cipher> Instance { get; } = new ObservableCollection<Cipher>
        {
            new Cipher
            {
                Name = "بوليبيوس",
                CharactersSets = new List<CharactersSet>
                {
                    new CharactersSet
                    {
                        Name = "٧×٤",
                        Characters =
                        {
                            "١١", "١٢", "١٣", "١٤", "١٥", "١٦", "١٧",
                            "٢١", "٢٢", "٢٣", "٢٤", "٢٥", "٢٦", "٢٧",
                            "٣١", "٣٢", "٣٣", "٣٤", "٣٥", "٣٦", "٣٧",
                            "٤١", "٤٢", "٤٣", "٤٤", "٤٥", "٤٦", "٤٧"
                        }
                    },

                    new CharactersSet
                    {
                        Name = "٤×٧",
                        Characters =
                        {
                            "١١", "١٢", "١٣", "١٤",
                            "٢١", "٢٢", "٢٣", "٢٤",
                            "٣١", "٣٢", "٣٣", "٣٤",
                            "٤١", "٤٢", "٤٣", "٤٤",
                            "٥١", "٥٢", "٥٣", "٥٤",
                            "٦١", "٦٢", "٦٣", "٦٤",
                            "٧١", "٧٢", "٧٣", "٧٤",
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "يسوع",
                CharactersSets =
                {
                    new CharactersSet
                    {
                        Characters = 
                        { 
                            "ي١", "ي٢", "ي٣", "ي٤", "ي٥", "ي٦", "ي٧",
                            "س١", "س٢", "س٣", "س٤", "س٥", "س٦", "س٧",
                            "و١", "و٢", "و٣", "و٤", "و٥", "و٦", "و٧",
                            "ع١", "ع٢", "ع٣", "ع٤", "ع٥", "ع٦", "ع٧"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "الرقمية",
                CharactersSets =
                {
                    new CharactersSet
                    {
                        Characters =
                        {
                            "١" , "٢" , "٣" , "٤" , "٥" , "٦" , "٧" ,
                            "٨" , "٩" , "١٠", "١١", "١٢", "١٣", "١٤",
                            "١٥", "١٦", "١٧", "١٨", "١٩", "٢٠", "٢١",
                            "٢٢", "٢٣", "٢٤", "٢٥", "٢٦", "٢٧", "٢٨"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "الرومانية",
                CharactersSets =
                {
                    new CharactersSet
                    {
                        Characters =
                        {
                            "I"   , "II"   , "III" , "IV"   , "V"   , "VI"   , "VII",
                            "VIII", "IX"   , "X"   , "XI"   , "XII" , "XIII" , "XIV",
                            "XV"  , "XVI"  , "XVII", "XVIII", "XIX" , "XX"   , "XXI",
                            "XXII", "XXIII", "XXIV", "XXV"  , "XXVI", "XXVII", "XXVIII"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "الأعداد الثنائية",
                CharactersSets =
                {
                    new CharactersSet
                    {
                        Characters =
                        {
                            "00001", "00010", "00011", "00100", "00101", "00110", "00111",
                            "01000", "01001", "01010", "01011", "01100", "01101", "01110",
                            "01111", "10000", "10001", "10010", "10011", "10100", "10101",
                            "10110", "10111", "11000", "11001", "11010", "11011", "11100"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "العكسية",
                CharactersSets =
                {
                    new CharactersSet
                    {
                        Characters =
                        {
                            "ي", "و", "ه", "ن", "م", "ل", "ك",
                            "ق", "ف", "غ", "ع", "ظ", "ط", "ض",
                            "ص", "ش", "س", "ز", "ر", "ذ", "د",
                            "خ", "ح", "ج", "ث", "ت", "ب", "ا"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "قيصر",
                CharactersSets =
                {
                    new CharactersSet
                    {
                        Characters =
                        {
                            "ب", "ت", "ث", "ج", "ح", "خ", "د",
                            "ذ", "ر", "ز", "س", "ش", "ص", "ض",
                            "ط", "ظ", "ع", "غ", "ف", "ق", "ك",
                            "ل", "م", "ن", "ه", "و", "ي", "ا"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "المورس",
                Key = new Key { IsEnabled = false },
                Type = CipherType.Audible,
                CharactersSets =
                {
                    new CharactersSet
                    {
                        Characters =
                        {
                            "(•-)"  , "(-•••)", "(-)"   , "(-•-•)", "(•---)" , "(••••)", "(---)" ,
                            "(-••)" , "(--••)", "(•-•)" , "(---•)", "(•••)"  , "(----)", "(-••-)",
                            "(•••-)", "(••-)" , "(-•--)", "(•-•-)", "(--•)"  , "(••-•)", "(--•-)",
                            "(-•-)" , "(•-••)", "(--)"  , "(-•)"  , "(••-••)", "(•--)" , "(••)"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "البوصلة",
                CharactersSets =
                {
                    new CharactersSet
                    {
                        Characters =
                        {
                            "N(١)", "NE(١)", "E(١)", "SE(١)", "S(١)", "SW(١)", "W(١)", "NW(١)",
                            "N(٢)", "NE(٢)", "E(٢)", "SE(٢)", "S(٢)", "SW(٢)", "W(٢)", "NW(٢)",
                            "N(٣)", "NE(٣)", "E(٣)", "SE(٣)", "S(٣)", "SW(٣)", "W(٣)", "NW(٣)",
                            "N(٤)", "NE(٤)", "E(٤)", "SE(٤)"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "الساعة",
                CharactersSets = 
                {
                    new CharactersSet
                    {
                        Name = "CW",
                        Characters =
                        {
                            "١:١٢", "١:١", "١:٢" , "١:٣" , "١:٤" , "١:٥" , "١:٦",
                            "١:٧", "١:٨" , "١:٩" , "١:١٠", "١:١١", "٢:١٢", "٢:١",
                            "٢:٢", "٢:٣" , "٢:٤" , "٢:٥" , "٢:٦" , "٢:٧" , "٢:٨",
                            "٢:٩", "٢:١٠", "٢:١١", "٣:١٢", "٣:١" , "٣:٢" , "٣:٣"
                        }
                    },

                    new CharactersSet
                    {
                        Name = "CCW",
                        Characters =
                        {
                            "١:١٢", "١:١١", "١:١٠", "١:٩" , "١:٨" , "١:٧" , "١:٦" ,
                            "١:٥" , "١:٤" , "١:٣" , "١:٢" , "١:١" , "٢:١٢", "٢:١١",
                            "٢:١٠", "٢:٩" , "٢:٨" , "٢:٧" , "٢:٦" , "٢:٥" , "٢:٤" ,
                            "٢:٣" , "٢:٢" , "٢:١" , "٣:١٢", "٣:١١", "٣:١٠", "٣:٩"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "الجوال",
                Key = new Key { IsEnabled = false },
                CharactersSets = 
                {
                    new CharactersSet
                    {
                        Name = "أ = ٣",
                        Characters =
                        {
                            "٣"   , "٢"   , "٢٢"   , "٢٢٢" , "٦"   , "٦٦" , "٦٦٦",
                            "٥"   , "٥٥"  , "٥٥٥"  , "٥٥٥٥", "٤"   , "٤٤" , "٤٤٤",
                            "٤٤٤٤", "٩"   , "٩٩"   , "٩٩٩" , "٩٩٩٩", "٨"  , "٨٨" ,
                            "٨٨٨" , "٨٨٨٨", "٨٨٨٨٨", "٧"   , "٧٧"  , "٧٧٧", "٧٧٧٧"
                        }
                    },

                    new CharactersSet
                    {
                        Name = "أ = ٣^١",
                        Characters =
                        {
                            "٣^١", "٢^١", "٢^٢", "٢^٣", "٦^١", "٦^٢", "٦^٣",
                            "٥^١", "٥^٢", "٥^٣", "٥^٤", "٤^١", "٤^٢", "٤^٣",
                            "٤^٤", "٩^١", "٩^٢", "٩^٣", "٩^٤", "٨^١", "٨^٢",
                            "٨^٣", "٨^٤", "٨^٥", "٧^١", "٧^٢", "٧^٣", "٧^٤"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "إكس",
                Key = new Key { Weight = 7 },
                CharactersSets =
                {
                    new CharactersSet
                    {
                        Characters =
                        {
                            "˅١", "˅٢", "˅٣", "˅٤", "˅٥", "˅٦", "˅٧",
                            "˂١", "˂٢", "˂٣", "˂٤", "˂٥", "˂٦", "˂٧",
                            "˄١", "˄٢", "˄٣", "˄٤", "˄٥", "˄٦", "˄٧",
                            "˃١", "˃٢", "˃٣", "˃٤", "˃٥", "˃٦", "˃٧"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "النجمة",
                Key = new Key { Weight = 7 },
                Type = CipherType.Geometric,
                CharactersSets = 
                {
                    new CharactersSet
                    {
                        Name = "▶▲▼◀",
                        Characters = 
                        {
                            "▲١", "▲٢", "▲٣", "▲٤", "▲٥", "▲٦", "▲٧",
                            "▶١", "▶٢", "▶٣", "▶٤", "▶٥", "▶٦", "▶٧",
                            "▼١", "▼٢", "▼٣", "▼٤", "▼٥", "▼٦", "▼٧",
                            "◀١", "◀٢", "◀٣", "◀٤", "◀٥", "◀٦", "◀٧"
                        }
                    },
                    new CharactersSet
                    {
                        Name = "▷△▽◁",
                        Characters =
                        {
                            "△١", "△٢", "△٣", "△٤", "△٥", "△٦", "△٧",
                            "▷١", "▷٢", "▷٣", "▷٤", "▷٥", "▷٦", "▷٧",
                            "▽١", "▽٢", "▽٣", "▽٤", "▽٥", "▽٦", "▽٧",
                            "◁١", "◁٢", "◁٣", "◁٤", "◁٥", "◁٦", "◁٧"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "المعين",
                Type = CipherType.Geometric,
                CharactersSets = 
                {
                    new CharactersSet
                    {
                        Name = "◤◣◢◥",
                        Characters =
                        {
                            "١◣", "١◢", "١◤", "١◥",
                            "٢◣", "٢◢", "٢◤", "٢◥",
                            "٣◣", "٣◢", "٣◤", "٣◥",
                            "٤◣", "٤◢", "٤◤", "٤◥",
                            "٥◣", "٥◢", "٥◤", "٥◥",
                            "٦◣", "٦◢", "٦◤", "٦◥",
                            "٧◣", "٧◢", "٧◤", "٧◥"
                        }
                    },
                    new CharactersSet
                    {
                        Name = "◸◺◿◹",
                        Characters =
                        {
                            "١◺", "١◿", "١◸", "١◹",
                            "٢◺", "٢◿", "٢◸", "٢◹",
                            "٣◺", "٣◿", "٣◸", "٣◹",
                            "٤◺", "٤◿", "٤◸", "٤◹",
                            "٥◺", "٥◿", "٥◸", "٥◹",
                            "٦◺", "٦◿", "٦◸", "٦◹",
                            "٧◺", "٧◿", "٧◸", "٧◹"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "المثلث",
                Type = CipherType.Geometric,
                CharactersSets = 
                {
                    new CharactersSet
                    {
                        Name = "◣◼◢",
                        Characters =
                        {
                            "١▲",
                            "٢◣◼", "٢◼◢",
                            "٣◣◼", "٣◼(١)", "٣◼◢",
                            "٤◣◼", "٤◼(١)", "٤◼(٢)", "٤◼◢",
                            "٥◣◼", "٥◼(١)", "٥◼(٢)", "٥◼(٣)", "٥◼◢",
                            "٦◣◼", "٦◼(١)", "٦◼(٢)", "٦◼(٣)", "٦◼(٤)", "٦◼◢",
                            "٧◣◼", "٧◼(١)", "٧◼(٢)", "٧◼(٣)", "٧◼(٤)", "٧◼(٥)", "٧◼◢"
                        }
                    },
                    new CharactersSet
                    {
                        Name = "◺◻◿",
                        Characters =
                        {
                            "١△",
                            "٢◺◻", "٢◻◿",
                            "٣◺◻", "٣◻(١)", "٣◻◿",
                            "٤◺◻", "٤◻(١)", "٤◻(٢)", "٤◻◿",
                            "٥◺◻", "٥◻(١)", "٥◻(٢)", "٥◻(٣)", "٥◻◿",
                            "٦◺◻", "٦◻(١)", "٦◻(٢)", "٦◻(٣)", "٦◻(٤)", "٦◻◿",
                            "٧◺◻", "٧◻(١)", "٧◻(٢)", "٧◻(٣)", "٧◻(٤)", "٧◻(٥)", "٧◻◿"
                        }
                    }
                }
            },

            new Cipher
            {
                Name = "الاسماء",
                Key = new Key { IsEnabled = false },
                CharactersSets =
                {
                    new CharactersSet
                    {
                        Characters =
                        {
                            "ايفغيني", "باتراش", "تيفادار" , "ثيوفيلوس", "جينريش"  , "حيرام", "خوارزم",
                            "ديمتري" , "ذاخر"  , "ريموند"  , "زوريس"   , "سيمين"    , "شارلس", "صالح"  ,
                            "ضرار"   , "طيب"   , "ظاهر"     , "عمار"    , "غولييلمو", "فيودور", "قيصر" ,
                            "كلارنس"  , "ليونتي", "موراساكي", "نيلس"    , "هيلج"     , "ويلارد", "يافيم"
                        }
                    }
                }
            }
        };
    }
}

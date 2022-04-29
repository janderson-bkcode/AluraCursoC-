﻿using Xunit;

namespace Humanizer.Tests.Localisation.uzLatn
{
    [UseCulture("uz-Latn-UZ")]
    public class NumberToWordsTests
    {

        [Theory]
        [InlineData(0, "nol")]
        [InlineData(1, "bir")]
        [InlineData(10, "o`n")]
        [InlineData(11, "o`n bir")]
        [InlineData(12, "o`n ikki")]
        [InlineData(13, "o`n uch")]
        [InlineData(14, "o`n to`rt")]
        [InlineData(15, "o`n besh")]
        [InlineData(16, "o`n olti")]
        [InlineData(17, "o`n yetti")]
        [InlineData(18, "o`n sakkiz")]
        [InlineData(19, "o`n to`qqiz")]
        [InlineData(20, "yigirma")]
        [InlineData(30, "o`ttiz")]
        [InlineData(40, "qirq")]
        [InlineData(50, "ellik")]
        [InlineData(60, "oltmish")]
        [InlineData(70, "yetmish")]
        [InlineData(80, "sakson")]
        [InlineData(90, "to`qson")]
        [InlineData(100, "yuz")]
        [InlineData(200, "ikki yuz")]
        [InlineData(300, "uch yuz")]
        [InlineData(400, "to`rt yuz")]
        [InlineData(500, "besh yuz")]
        [InlineData(600, "olti yuz")]
        [InlineData(700, "yetti yuz")]
        [InlineData(800, "sakkiz yuz")]
        [InlineData(900, "to`qqiz yuz")]
        [InlineData(1000, "bir ming")]
        [InlineData(2000, "ikki ming")]
        [InlineData(3000, "uch ming")]
        [InlineData(10000, "o`n ming")]
        [InlineData(100000, "yuz ming")]
        [InlineData(100100, "yuz ming bir yuz")]
        [InlineData(200100, "ikki yuz ming bir yuz")]
        [InlineData(1000000, "bir million")]
        [InlineData(1001000, "bir million bir ming")]
        [InlineData(1000100, "bir million bir yuz")]
        [InlineData(2000000, "ikki million")]
        [InlineData(10000000, "o`n million")]
        [InlineData(100000000, "yuz million")]
        [InlineData(100001000, "yuz million bir ming")]
        [InlineData(1000000000, "bir milliard")]
        [InlineData(2000000000, "ikki milliard")]
        [InlineData(122, "bir yuz yigirma ikki")]
        [InlineData(3501, "uch ming besh yuz bir")]
        [InlineData(111, "bir yuz o`n bir")]
        [InlineData(1112, "bir ming bir yuz o`n ikki")]
        [InlineData(11213, "o`n bir ming ikki yuz o`n uch")]
        [InlineData(121314, "bir yuz yigirma bir ming uch yuz o`n to`rt")]
        [InlineData(2132415, "ikki million bir yuz o`ttiz ikki ming to`rt yuz o`n besh")]
        [InlineData(12345516, "o`n ikki million uch yuz qirq besh ming besh yuz o`n olti")]
        [InlineData(751633617, "yetti yuz ellik bir million olti yuz o`ttiz uch ming olti yuz o`n yetti")]
        [InlineData(1111111118, "bir milliard bir yuz o`n bir million bir yuz o`n bir ming bir yuz o`n sakkiz")]
        [InlineData(-751633617, "minus yetti yuz ellik bir million olti yuz o`ttiz uch ming olti yuz o`n yetti")]
        public void ToWords(int number, string expected)
        {
            Assert.Equal(expected, number.ToWords());
        }

        [Theory]
        [InlineData(0, "nolinchi")]
        [InlineData(1, "birinchi")]
        [InlineData(10, "o`ninchi")]
        [InlineData(11, "o`n birinchi")]
        [InlineData(12, "o`n ikkinchi")]
        [InlineData(13, "o`n uchinchi")]
        [InlineData(14, "o`n to`rtinchi")]
        [InlineData(15, "o`n beshinchi")]
        [InlineData(16, "o`n oltinchi")]
        [InlineData(17, "o`n yettinchi")]
        [InlineData(18, "o`n sakkizinchi")]
        [InlineData(19, "o`n to`qqizinchi")]
        [InlineData(20, "yigirmanchi")]
        [InlineData(30, "o`ttizinchi")]
        [InlineData(40, "qirqinchi")]
        [InlineData(50, "ellikinchi")]
        [InlineData(60, "oltmishinchi")]
        [InlineData(70, "yetmishinchi")]
        [InlineData(80, "saksoninchi")]
        [InlineData(90, "to`qsoninchi")]
        [InlineData(100, "yuzinchi")]
        [InlineData(200, "ikki yuzinchi")]
        [InlineData(1000, "bir minginchi")]
        [InlineData(2000000, "ikki millioninchi")]
        [InlineData(1000000000, "bir milliardinchi")]
        [InlineData(122, "bir yuz yigirma ikkinchi")]
        [InlineData(3501, "uch ming besh yuz birinchi")]
        [InlineData(111, "bir yuz o`n birinchi")]
        [InlineData(751633617, "yetti yuz ellik bir million olti yuz o`ttiz uch ming olti yuz o`n yettinchi")]
        [InlineData(1111111118, "bir milliard bir yuz o`n bir million bir yuz o`n bir ming bir yuz o`n sakkizinchi")]
        [InlineData(-751633617, "minus yetti yuz ellik bir million olti yuz o`ttiz uch ming olti yuz o`n yettinchi")]
        public void ToOrdinalWords(int number, string words)
        {
            Assert.Equal(words, number.ToOrdinalWords());
        }
    }
}

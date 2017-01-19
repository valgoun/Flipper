using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsciiLetters {

    public static int[][] getLetterTable(char letter) {
        switch (char.ToUpper(letter)) {
            case 'A':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 }};

            case 'B':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 0 }};

            case 'C':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 }};

            case 'D':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 0 }};

            case 'E':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0 }};

            case 'F':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 }};

            case 'G':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 1, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 }};

            case 'H':
            return new int[][] {
                new int[] { 1, 0, 0, 1, 0 },
                new int[] { 1, 0, 0, 1, 0 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 1, 0 },
                new int[] { 1, 0, 0, 1, 0 }};

            case 'I':
            return new int[][] {
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 }};

            case 'J':
            return new int[][] {
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 }};

            case 'K':
            return new int[][] {
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 1, 0 },
                new int[] { 1, 1, 1, 0, 0 },
                new int[] { 1, 0, 0, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 }};

            case 'L':
            return new int[][] {
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0 }};

            case 'M':
            return new int[][] {
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 0, 1, 1 },
                new int[] { 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 }};

            case 'N':
            return new int[][] {
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 0, 0, 1 },
                new int[] { 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 0, 1, 1 },
                new int[] { 1, 0, 0, 0, 1 }};

            case 'O':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 }};

            case 'P':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 }};

            case 'Q':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 0, 1, 1 },
                new int[] { 0, 1, 1, 1, 1 }};

            case 'R':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 }};

            case 'S':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 0 }};

            case 'T':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 }};

            case 'U':
            return new int[][] {
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 }};

            case 'V':
            return new int[][] {
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 0, 1, 0 },
                new int[] { 0, 0, 1, 0, 0 }};

            case 'W':
            return new int[][] {
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 0, 1, 1 },
                new int[] { 1, 0, 1, 0, 1 }};

            case 'X':
            return new int[][] {
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 0, 1, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 1, 0, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 }};

            case 'Y':
            return new int[][] {
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 0, 1, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 }};

            case 'Z':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 1, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 }};

            case '0':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 }};

            case '1':
            return new int[][] {
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 1, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 }};

            case '2':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 }};

            case '3':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 0 }};

            case '4':
            return new int[][] {
                new int[] { 0, 0, 1, 1, 0 },
                new int[] { 0, 1, 0, 1, 0 },
                new int[] { 1, 0, 0, 1, 0 },
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 1, 0 }};

            case '5':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 0 }};

            case '6':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 }};

            case '7':
            return new int[][] {
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 0, 0, 0, 1, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0 }};

            case '8':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 }};

            case '9':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 0, 1, 1, 1, 0 }};

            case '?':
            return new int[][] {
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 0, 0, 0, 1, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 }};

            case ':':
            return new int[][] {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 }};

            case ' ':
            return new int[][] {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 }};



            default:
            return new int[][] {
                new int[] { 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0, 1 }};
        }
    }

}

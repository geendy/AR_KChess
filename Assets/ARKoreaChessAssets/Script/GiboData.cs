﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiboData : MonoBehaviour {
    string[] g1 = new string[]{"[대회명 \"2018 회장배\"]",
    "[회전 \"결승전 제2국\"]",
    "[대국일자 \"2018-12-09\"]",
    "[대국장소 \"본 협회 특별대국실\"]",
    "[초대국자 \"김철 8단\"]",
    "[한대국자 \"안동건 9단\"]",
    "[초차림 \"상마상마\"]",
    "[한차림 \"마상상마\"]",
    "[제한시간 \"각 1시간 40초 초읽기 3회\"]",
    "[총수 \"54\"]",
    "[대국결과 \"초 완승\"]",
"1. 71졸72 2. 18마37 3. 02마83 4. 12마33 5. 82포85 6. 38포35",
"7. 08상76 8. 45병46 9. 75졸74 10. 37마45 11. 03상75 12. 43병53",
"13. 07마99 14. 32포34 15. 99마87 16. 41병51 17. 88포86 18. 25장15",
"19. 09차08 20. 11차21 21. 08차38 22. 34포32 23. 76상44 24. 16사25",
"25. 77졸67 26. 21차41 27. 87마66 28. 49병48 29. 79졸78 30. 45마66마",
"31. 67졸66마 32. 17상45 33. 44상76 34. 32포34 35. 75상47병장군 36. 48병47상",
"37. 76상53병 38. 33마54 39. 66졸67 40. 51병52 41. 01차41차 42. 13상41차",
"43. 38차58 44. 54마33 45. 83마75 46. 19차99장군 47. 95장05 48. 99차93",
"49. 53상76 50. 41상73졸장군 51. 74졸73상 52. 45상73졸장군 53. 72졸73상 54. 93차73졸"};
    string[] g2 = new string[]
    {
    "[대회명 \"2018 회장배\"]",
    "[회전 \"결승전 제3국\"]",
    "[대국일자 \"2018-12-23\"]",
    "[대국장소 \"본 협회 특별대국실\"]",
    "[초대국자 \"김철 8단\"]",
    "[한대국자 \"안동건 9단\"]",
    "[초차림 \"마상마상\"]",
    "[한차림 \"마상상마\"]",
    "[제한시간 \"각 1시간 40초 초읽기 3회\"]",
    "[총수 \"145\"]",
    "[대국결과 \"초 점수승\"]",
   "1. 79졸78 2. 18마37 3. 08마87 4. 12마33 5. 03마84 6. 32포35",
    "7. 82포85 8. 45병44 9. 71졸72 10. 38포36 11. 09차69 12. 33마45",
    "13. 75졸76 14. 11차31 15. 07상75 16. 47병57 17. 88포86 18. 31차33",
    "19. 01차91 20. 25장15 21. 95장05 22. 14사25 23. 04사95 24. 36포14",
    "25. 86포04 26. 16사26 27. 06사96 28. 49병59 29. 69차62 30. 19차49",
    "31. 62차22 32. 37마56 33. 73졸63 34. 59병58 35. 72졸62 36. 15장16",
    "37. 62졸52 38. 49차69 39. 91차93 40. 35포15 41. 78졸79 42. 69차39",
    "43. 04포06 44. 33차32 45. 22차23 46. 39차33 47. 23차33차 48. 32차33차",
    "49. 76졸66 50. 56마37 51. 66졸65 52. 15포35 53. 63졸64 54. 16장15 ",
    "55. 84마63 56. 43병53 57. 63마84 58. 44병54 59. 52졸53병 60. 54병53졸",
    "61. 93차92 62. 37마56 63. 77졸76 64. 45마64졸 65. 65졸64마 66. 56마64졸",
    "67. 85포65 68. 57병56 69. 92차62 70. 53병54 71. 62차63 72. 33차63차",
    "73. 84마63차 74. 54병53 75. 63마82 76. 58병57 77. 87마68 78. 56병55",
    "79. 65포85 80. 57병58 81. 68마87 82. 64마85포 83. 02상85마 84. 55병65",
    "85. 75상92 86. 53병54 87. 76졸75 88. 54병64 89. 75졸65병 90. 64병65졸",
    "91. 82마74 92. 13상45 93. 06포46 94. 45상73장군 95. 05장06 96. 17상45",
    "97. 79졸78 98. 41병51 99. 78졸68 100. 58병59 101. 68졸67 102. 51병52",
    "103. 67졸66 104. 65병64 105. 74마93 106. 59병58 107. 87마79 108. 58병57",
    "109. 85상68 110. 52병62 111. 68상45상 112. 14포16 113. 45상62병 114. 64병63",
    "115. 93마85 116. 57병56 117. 62상94 118. 56병55 119. 79마87 120. 55병54",
    "121. 92상75 122. 15장14 123. 75상58 124. 35포15 125. 94상71 126. 54병53",
    "127. 85마73상 128. 63병73마 129. 58상26사 130. 25사26상 131. 71상43 132. 15포13",
    "133. 43상26사 134. 73병74 135. 26상43 136. 53병54 137. 46포86 138. 14장25",
    "139. 66졸56 140. 13포53 141. 56졸46 142. 16포56 143. 87마68 144. 74병75",
    "145. 68마56포"
    };
    string[] g3 = new string[]
    {
    "[대회명 \"2018 회장배\"]",
    "[회전 \"결승전 제4국\"]",
    "[대국일자 \"2018-12-23\"]",
    "[대국장소 \"본 협회 특별대국실\"]",
    "[초대국자 \"안동건 9단\"]",
    "[한대국자 \"김  철 8단\"]",
    "[초차림 \"상마상마\"]",
    "[한차림 \"마상상마\"]",
    "[제한시간 \"각 1시간 40초 초읽기 3회\"]",
    "[총수 \"68\"]",
    "[대국결과 \"한 완승\"]",
    "1. 71졸72 2. 18마37 3. 02마83 4. 38포35 5. 82포85 6. 12마33",
    "7. 08상76 8. 45병46 9. 79졸78 10. 37마45 11. 75졸74 12. 32포34",
    "13. 01차61 14. 47병57 15. 07마86 16. 46병56 17. 61차63 18. 41병42",
    "19. 03상71 20. 56병66 21. 71상43병 22. 42병43상 23. 63차43병 24. 16사26",
    "25. 83마75 26. 11차41 27. 43차41차 28. 13상41차 29. 85포45마 30. 17상45포",
    "31. 88포85 32. 34포16 33. 06사96 34. 25장15 35. 95장06 36. 14사25",
    "37. 04사95 38. 57병67 39. 85포05 40. 67병77졸 41. 78졸77병 42. 19차17",
    "43. 75마94 44. 17차77졸 45. 76상53 46. 77차47 47. 74졸75 48. 45상68",
    "49. 53상25사 50. 68상96사 51. 95사96상 52. 26사25상 53. 73졸74 54. 41상13",
    "55. 09차07 56. 47차48 57. 07차57 58. 33마45 59. 57차56 60. 48차68",
    "61. 94마73 62. 25사36 63. 56차52 64. 66병76 65. 75졸76병 66. 16포76졸",
    "67. 73마54 68. 68차98"
    };
    string[] g4 = new string[]
    {
    "[대회명 \"2018 회장배\"]",
    "[회전 \"3,4위전  제1국\"]",
    "[대국일자 \"2018-12-09\"]",
    "[대국장소 \"본 협회 특별대국실\"]",
    "[초대국자 \"김명환 아마4단\"]",
    "[한대국자 \"유종범 3단\"]",
    "[초차림 \"마상상마\"]",
    "[한차림 \"상마상마\"]",
    "[제한시간 \"각 1시간 40초 초읽기 3회\"]",
    "[총수 \"103\"]",
    "[대국결과 \"초 점수승\"]",
    "1. 79졸78 2. 13마34 3. 08마87 4. 32포35 5. 02마83 6. 45병46장군",
    "7. 82포85 8. 41병42 9. 75졸74 10. 17상45 11. 88포86 12. 18마37",
    "13. 95장05 14. 38포36 15. 04사95 16. 25장15 17. 86포04 18. 14사25",
    "19. 07상75 20. 36포14 21. 85포81 22. 35포31 23. 75상43병장군 24. 42병43상",
    "25. 03상75 26. 43병44 27. 04포44병 28. 11차21 29. 44포04 30. 21차23",
    "31. 71졸72 32. 31포35 33. 81포85 34. 16사26 35. 09차69 36. 49병48",
    "37. 69차19차장군 38. 14포19차 39. 01차11 40. 15장16 41. 77졸67 42. 23차53",
    "43. 06사96 44. 34마55 45. 75상47병 46. 55마74졸 47. 73졸74마 48. 53차83마",
    "49. 47상75 50. 83차82 51. 72졸73 52. 82차02 53. 11차41 54. 19포14",
    "55. 41차43 56. 14포17 57. 78졸68 58. 48병58 59. 68졸58병 60. 37마58졸",
    "61. 67졸68 62. 58마37 63. 87마66 64. 46병56 65. 66마58 66. 37마58마",
    "67. 75상58마 68. 45상68졸 69. 58상35포 70. 12상35상 71. 43차47 72. 17포14",
    "73. 47차67 74. 68상96사 75. 05장06 76. 56병55 77. 67차77 78. 55병65",
    "79. 06장96상 80. 65병66 81. 96장06 82. 16장15 83. 06장05 84. 14포16",
    "85. 77차37 86. 02차32 87. 74졸75 88. 32차33 89. 73졸74 90. 33차03",
    "91. 85포35상장군 92. 25사35포 93. 37차35사장군 94. 26사25 95. 35차55 96. 03차01",
    "97. 55차54 98. 66병67 99. 54차64 100. 67병77 101. 64차67 102. 77병78",
    "103. 67차68"
    };
    string[] g5 = new string[]
    {
    "[대회명 \"2018 회장배\"]",
    "[회전 \"3,4위전  제2국\"]",
    "[대국일자 \"2018-11-15\"]",
    "[대국장소 \"본 협회 특별대국실\"]",
    "[초대국자 \"김명환 아마4단\"]",
    "[한대국자 \"유종범 3단\"]",
    "[초차림 \"마상마상\"]",
    "[한차림 \"마상상마\"]",
    "[제한시간 \"각 1시간 40초 초읽기 3회\"]",
    "[총수 \"78\"]",
    "[대국결과 \"한 점수승\"]",
    "1. 71졸72 2. 12마33 3. 03마84 4. 32포35 5. 01차61 6. 18마37",
    "7. 79졸78 8. 45병44장군 9. 82포85 10. 38포36 11. 08마87 12. 33마45",
    "13. 95장05 14. 47병57 15. 77졸76 16. 16사26 17. 88포86 18. 25장15",
    "19. 61차91 20. 17상34 21. 91차97 22. 14사25 23. 78졸68 24. 36포14",
    "25. 02상74 26. 41병42 27. 06사95 28. 42병52 29. 74상46 30. 26사36",
    "31. 87마66 32. 57병56 33. 66마74 34. 19차18 35. 97차98 36. 11차61",
    "37. 07상79 38. 61차68졸 39. 98차68차 40. 18차68차 41. 79상56병 42. 14포16",
    "43. 46상69 44. 49병59 45. 56상39 46. 16포14 47. 39상67 48. 68차67상",
    "49. 73졸63 50. 59병69상 51. 04사94 52. 36사26 53. 86포04 54. 44병54",
    "55. 74마82 56. 54병64 57. 63졸64병 58. 45마64졸 59. 82마74 60. 64마76졸",
    "61. 75졸76마 62. 14포74마 63. 76졸75 64. 74포14 65. 84마65 66. 14포16",
    "67. 09차08 68. 69병68 69. 08차88 70. 35포75졸 71. 65마73 72. 43병53",
    "73. 94사84 74. 37마45 75. 04포08 76. 34상57 77. 08포68병 78. 67차07장군"
    };
    // Use this for initialization
    void Start() {

    }
    public string getGiboData(int gibo, int i) {
        string s = "1";
        switch (gibo) {
            case 1:
                s = g1[i];
                break;

            case 2:
                s = g2[i];
                break;
            case 3:
                s = g3[i];
                break;
            case 4:
                s = g4[i];
                break;
            case 5:
                s = g5[i];
                break;

        }
        return s;

    }
    public int getGiboDataSize(int gibo) {
        int i = 1;
        switch (gibo) {
            case 1:
                i = g1.Length;
                break;

            case 2:
                i = g2.Length;
                break;
            case 3:
                i = g3.Length;
                break;
            case 4:
                i = g4.Length;
                break;
            case 5:
                i = g5.Length;
                break;
        }
        return i;
    }
    // Update is called once per frame
    void Update() {

    }
}
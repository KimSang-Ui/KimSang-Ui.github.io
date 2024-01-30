---
layout: single
title:  "15번째 포스팅입니다!"
---
# Math.random으로 로또번호 생성
---------------------------------------------------------------------------------------------------
    package Lotto;

    public class Lotto {
	public static void main(String[] args) {

		int lotto[] = new int[7];

		for (int i = 0; i < 6; i++) {

			lotto[i] = (int) (Math.random() * 45) + 1;// 45번까지 번호 생성

			for (int j = 0; j < i; j++) {

				if (lotto[i] == lotto[j]) {

					i--;
				}
				break;// 중복 번호 제거되면 번호출력
			}
		}

		for (int i = 0; i < 7; i++) {

			System.out.print(lotto[i] + " "); // 번호 출력
		}
	}
    }

---
layout: single
title:  "13번째 포스팅입니다!"
---
# 자바언어로 로또번호 생성
---------------------------------------------------------------------------------------------------
package lotto;

public class lotto {


public static void main(String[] args) {
	
 
 int lotto[] = new int [7];
	
for(int i=0; i<6; i++) {
		
lotto[i] = (int)(Math.random() * 45) + 1;// 46번까지 번호 생성
        
   		  	 
for(int j=0; j<i; j++) {
			
if(lotto[i] == lotto[j]) {
				
			continue;// 중복 번호 나오면 계속 돌린다
			}
				break;// 중복 번호 제거되면 번호출력
			}
		}
	

for(int i=0; i<7; i++) {
	
 System.out.print(lotto[i] + " "); // 번호 출력
}
}
}


 }

}

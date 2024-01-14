---
layout: single
title:  "13-1번째 포스팅입니다!"
---
# Switch 구문

public class Switch {

    public static void main(String[] args) {
       
        int grade = 1;

        int coupon;
        
        switch (grade) {
            
            case 1:
                
                coupon = 1000;
                
                break;
          
            case 2:
                
                coupon = 2000;
              
                break;
           
            case 3:
                
                coupon = 3000;
              
                break;
           
            default:
               
                coupon = 500;
        }
        System.out.println("발급받은 쿠폰 " + coupon);
    }
}
grade가 1이기 때문에 "발급받은 쿠폰" 1000이 출력된다

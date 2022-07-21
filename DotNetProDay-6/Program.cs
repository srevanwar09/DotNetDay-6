static Boolean isPresent(int[] arr, int num) 
{
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] == num) 
        {
            return true;
        }
    }
    return false;
}
static void generateCouponCode(int totalNum)
{
    int[] couponCode = new int[totalNum];
    int randomNo = 0, count=0;
    Boolean check;
    Random random = new Random();
    for (int i = 0; i < couponCode.Length; i++)
    {
        randomNo = random.Next(1000, 10000);
        count++;
        check = isPresent(couponCode, randomNo);
        if (check != true) 
        {
            couponCode[i] = randomNo;
        }
        else
        {
            --i;
        }
    }
    Console.WriteLine("The unique coupon numbers are :");
    for (int i = 0; i < couponCode.Length; i++)
    {
        Console.WriteLine(couponCode[i] + " ");
    }
    Console.WriteLine("Total random number needed to have all distinct numbers are : "+count);
}
Console.Write("Enter the number of coupon codes to be generated : ");
int totalNum = int.Parse(Console.ReadLine());
generateCouponCode(totalNum);
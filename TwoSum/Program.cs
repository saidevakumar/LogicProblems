
/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
*/

int[] nums = new int[] {1,2,3,4,5};
int target = 7;

List<int> result = TwoSum(nums,target);
Console.WriteLine(string.Format("[{0}]",string.Join(",",result)));   

List<int> TwoSum(int[] nums, int target) {
    
    int outerLoopcount = 0, innerLoopcount = 0;

    List<int> col = new List<int>();

    //Iterate throught the array.
    for(int index=0;index<nums.Length;index++)
    {
        outerLoopcount++;

        //Iterate through the array starting with second number in the array.
        for(int idx=index+1;idx<nums.Length;idx++)
        {
            innerLoopcount++;
            if (nums[idx] == (target - nums[index]))
            {
                col.Add(nums[index]);
                col.Add(nums[idx]);
                return col;
            }            
        }   
    }
    
    Console.WriteLine(string.Format("outerLoopcount {0}, innerLoopcount {1}",outerLoopcount,innerLoopcount));   
   
    return col;
}
using LeetCodeSolutions;

// TwoSum

TwoSums twoSums = new TwoSums();
var result = twoSums.TwoSumWithDictionary(new int[3]{ 3, 2, 4 }, 6);
var resultByDic = twoSums.TwoSumWithDictionary(new int[5]{ -1, -2, -3, -4, -5 }, -8);

Console.WriteLine();


// ValidParentheses

ValidParentheses validParentheses = new ValidParentheses();
var isValid = validParentheses.IsValid("[([]])");
var isValidWithStack = validParentheses.IsValidWithStack("[([]])");

Console.WriteLine();
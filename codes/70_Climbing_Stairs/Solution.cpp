#include "Solution.h"


Solution::Solution()
{

}

Solution::~Solution()
{

}

int Solution::climbStairs(int n) {
	if (n == 1) return 1;
	else if (n == 2) return 2;

	int first = 1;
	int second = 2;
	int stairs = 0;

	int index = 2;

	while (index < n) {
		stairs = first + second;
		first = second;
		second = stairs;

		index++;
	}

	return stairs;
}
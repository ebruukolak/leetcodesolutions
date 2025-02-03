﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    /// <summary>
    /// You are given the heads of two sorted linked lists list1 and list2.
    /// Merge the two lists into one sorted list. 
    /// The list should be made by splicing together the nodes of the first two lists.
    /// Return the head of the merged linked list.
    /// 
    /// Example:
    ///  Input: list1 = [1,2,4], list2 = [1,3,4]
    ///  Output: [1, 1, 2, 3, 4, 4]
    ///  
    /// </summary>
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var sortedHead = new ListNode();
            ListNode current = sortedHead;

            while (list1 != null && list2 != null)
            {

                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;

            }

            current.next = list1 != null ? list1 : list2;
            return sortedHead.next;

        }


        public void RunMergedTwoSortedLists()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            ListNode mergedList = MergeTwoLists(list1, list2);


            Console.Write("Merged List: ");
            while (mergedList != null)
            {
                Console.Write(mergedList.val + " ");
                mergedList = mergedList.next;
            }

        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }





}

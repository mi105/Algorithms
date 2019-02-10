using System;
using System.Collections.Generic;

namespace SingleLinkedListReverse
{
  //Definition for singly-linked list.
  public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }

    public override string ToString()
    {
        string s = string.Empty;
        var tmp = this;
        while(tmp!=null)
        {
            s+= $"{tmp.val}--->";
            tmp=tmp.next;
        }
        s+= "null";
        return s;
    }

    public ListNode Reverse(int len){
        var current = this;
        ListNode previous = null;
        int i=0;
        while(current!=null && i<=len)
        {
            var copy = new ListNode(current.val);
            copy.next = current.next;
            current.next =previous;
            previous = current;
            current = copy.next;
            i++;
        }
        var iter = previous;
        iter.next=previous.next;
        while(iter.next!=null)
        {
            iter=iter.next;
        }
        iter.next = current;
        return previous;
    }

     public ListNode Reverse(int startAt, int length){
        var current = this;
        ListNode previous = null;
        for(int i=0; 
        i<startAt && current.next!=null;
        i++)
        {
            previous = current;
            previous.next = current.next;
            current=previous.next;
        }
        previous.next = current.Reverse(length);
        return this;
    }

  }
 
    class SingleLinkedListReverse
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            var tmp=head;
            tmp.next = new ListNode(2);
            tmp= tmp.next;
            tmp.next = new ListNode(3);
            tmp= tmp.next;
            tmp.next = new ListNode(4);
            tmp= tmp.next;
            tmp.next = new ListNode(5);
            tmp= tmp.next;
            tmp.next = new ListNode(6);
            tmp= tmp.next;
            tmp.next = new ListNode(7);
            tmp= tmp.next;
            tmp.next = null;
            Console.WriteLine(head.Reverse(5,2).ToString());
        }
    }
}

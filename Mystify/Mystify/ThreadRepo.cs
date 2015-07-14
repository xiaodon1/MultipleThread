/*
 *FileName      :ThreadRepo.cs
 * Project      :PROG2120
 * Programmer   :Xiaodong Meng
 * First Version:10/21/2014
 * Description  :This file used to save threads, and handle the threads.
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mystify
{
    class ThreadRepo
    {
        List<Thread> threads = new List<Thread>();
        public ThreadRepo()
        { }


        //Function      :Add
        //Description   :Add a thrad to the list.
        //
        //Parameters    :Thread ts
        //
        //Returns       :none
        //
        //
        public void Add(Thread ts)
        {
            threads.Add(ts);
        }


        //Function      :StartAll
        //Description   :Start all the threads.
        //
        //Parameters    :none
        //
        //Returns       :none
        //
        //
        public void StartAll()
        {
            foreach (Thread t in threads)
            {
                t.Start();
            }
        }


        //Function      :JoinAll
        //Description   :Wait for all the thread terminated.
        //
        //Parameters    :none
        //
        //Returns       :none
        //
        //
        public void JoinAll()
        {
            foreach (Thread t in threads)
            {
                t.Join();
            }
        }



        //Function      :GetCount
        //Description   :The the current amount of the list.
        //
        //Parameters    :none
        //
        //Returns       :int : the amount of the list.
        //
        //
         public int GetCount()
        {
            return threads.Count;
        }



         //Function      :PauseThreads
         //Description   :Pause all the threads.
         //
         //Parameters    :none
         //
         //Returns       :none
         //
         //
        public void PauseThreads()
        {
            foreach(Thread t in threads)
            {
                try
                {
                    t.Suspend();
                }
                catch(Exception ex)
                {

                }
              
            }
        }


        //Function      :Clear
        //Description   :Clear the list.
        //
        //Parameters    :none
        //
        //Returns       :none
        //
        //
        public void Clear()
        {
            threads.Clear();
        }


        //Function      :ResumeThreads
        //Description   :Resume  threads if  threads were paused 
        //
        //Parameters    :
        //
        //Returns       :
        //
        //
        public void ResumeThreads()
        {
            foreach (Thread t in threads)
            {
                try
                {
                    t.Resume();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}

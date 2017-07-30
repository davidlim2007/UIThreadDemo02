using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIThreadDemo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateThread_Click(object sender, EventArgs e)
        {
            // The following code will initiate a new thread with 
            // WorkThreadFunction() as the entry point method.
            // Note that WorkThreadFunction() does not take any parameters
            // hence the use of the ThreadStart delegate.
            Thread thread = new Thread(new ThreadStart(WorkThreadFunction));

            // Note that the above call can be simplified to :
            // Thread thread = new Thread(WorkThreadFunction);
            // This is because the compiler is able to deduce that
            // WorkThreadFunction() does not take any parameter and so
            // the ThreadStart delegate type is implied.
            thread.Start();
        }

        // WorkThreadFunction() is the entry-point to a thread.
        // i.e. when the thread starts, it starts with WorkThreadFunction().
        public void WorkThreadFunction()
        {
            int i = 0;
            while (true)
            {
                i++;
                Thread.Sleep(1000);

                if (i >= 10)
                {
                    break;
                }
            }
        }

        private void btnCreateThreadWithParameter_Click(object sender, EventArgs e)
        {
            // The following code will initiate a new thread with 
            // WorkThreadFunctionWithParameter() as the entry point method.
            // Note that WorkThreadFunctionWithParameter() takes one parameter
            // hence the use of the ParameterizedThreadStart delegate.
            Thread thread = new Thread(new ParameterizedThreadStart(WorkThreadFunctionWithParameter));

            // Note that the above call can be simplified to :
            // Thread thread = new Thread(WorkThreadFunctionWithParameter);
            // This is because the compiler is able to deduce that
            // WorkThreadFunctionWithParameter() takes a parameter and so
            // the ParameterizedThreadStart delegate type is implied.
            // Note that if thread.Start() is called without any parameter,
            // then the parameter is set to null.
            thread.Start(5000);
        }

        // WorkThreadFunctionWithParameter() is the entry-point to a thread.
        // i.e. when the thread starts, it starts with WorkThreadFunctionWithParameter().
        // Note also that this method takes a parameter but it could be set to null.
        public void WorkThreadFunctionWithParameter(object objParameter)
        {
            int iDuration = 0;

            // Check whether objParameter is null in case Thread.Start()
            // is called without any parameters.
            if (objParameter != null)
            {
                iDuration = (int)objParameter;
            }

            Thread.Sleep(iDuration);
        }

        private void btnCreateThreadAnonymousEntryPoint_Click(object sender, EventArgs e)
        {
            // The following initiates a new thread with an anonymous entry-point
            // method (i.e. an entry point method without any name).
            // Note that the body of the anonymous method will only be executed
            // when the thread officially starts.
            Thread thread = new Thread((object objParameter) =>
            {
                // Thread entry point method.
                string strText = (string)objParameter;
                File.AppendAllText("test.txt", strText);
            });

            thread.Start("My text\r\n");
        }

        // This button handler will initiate a thread with 
        // WorkThreadFunctionWithTryCatch() as the entry point.
        // After initiating the thread, this handler will 
        // block for 1 second thereby allowing the
        // WorkThreadFunctionWithTryCatch() thread to start.
        // Immediately after that, this handler will instruct
        // the thread to abort.
        private void btnThreadAbort_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(WorkThreadFunctionWithTryCatch));
            thread.Start();

            // Halt the current thread for 1 second. This will allow the
            // OS to allow other threads to run.
            // Hence the WorkThreadFunctionWithTryCatch()
            // thread will start running.
            Thread.Sleep(1000);

            // Once WorkThreadFunctionWithTryCatch() starts running, 
            // we proceed to abort the thread by calling thread.Abort().
            // Doing so will cause a ThreadAbortException exception 
            // to be thrown inside the thread.
            thread.Abort();
        }

        // WorkThreadFunctionWithTryCatch() is the entry-point to a thread.
        // i.e. when the thread starts, it starts with WorkThreadFunctionWithTryCatch().
        public void WorkThreadFunctionWithTryCatch()
        {
            try
            {
                // Do a simple block for 10 seconds.
                Thread.Sleep(10000);
            }
            catch (ThreadAbortException taex)
            {
                // Code will reach here if the Thread.Abort()
                // methid is called on this thread.
                MessageBox.Show(taex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // The finally clause will always be executed
                // on method exit.
                MessageBox.Show("Thread ends.");
            }
        }
    }
}

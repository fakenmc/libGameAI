/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 *
 * Author: Nuno Fachada
 * */

namespace LibGameAI.BehaviorTrees
{
    // Implements a sequence node
    public class SequenceTask : CompositeTask
    {

        // Constructor, simply invokes the base constructor
        public SequenceTask(params ITask[] tasks)
            : base(new SequentialTaskOrderStrategy(), tasks) { }

        // Constructor, invokes base constructor with specific task order
        // strategy
        public SequenceTask(
            ITaskOrderStrategy taskOrderStrategy, params ITask[] tasks)
            : base(taskOrderStrategy, tasks) { }

        // Invokes the child tasks and returns as soon as one them returns false
        public override TaskResult Run()
        {
            foreach (ITask child in Tasks)
            {
                TaskResult result = child.Run();
                if (result != TaskResult.Success) return result;
            }
            return TaskResult.Success;
        }
    }
}

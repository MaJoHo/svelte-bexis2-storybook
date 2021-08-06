<script >
 import classnames from '../utils';
 import { afterUpdate } from 'svelte';
 import Prism from 'prismjs';
 let className = '';
 let isAsync = false;
 export { className as class };
 export { isAsync as async };
 let classes = classnames('language-html', className);
 let _domNode;
 afterUpdate(() => {
   Prism.highlightElement(_domNode, isAsync);
 });
</script>
<pre>
 <code class="{classes}" bind:this={_domNode}>
   <slot />
 </code>
</pre>
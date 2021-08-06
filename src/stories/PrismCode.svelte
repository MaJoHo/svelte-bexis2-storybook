<script>
  import Prism from '../../scripts/prism'
  import { afterUpdate } from 'svelte'

  let className = '';
  let isAsync = false;

  export { className as class };
  export { isAsync as async };

  let _domNode;
  afterUpdate(() => {
    Prism.highlightElement(_domNode, isAsync);
  });

</script>
<svelte:head>
	<link rel="stylesheet" href="/css/prism.css" >
</svelte:head>

<pre>
  <code class="{className}" bind:this={_domNode}>
    <slot />
  </code>
 </pre>
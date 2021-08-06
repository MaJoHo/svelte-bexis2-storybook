<script>

  import { Button } from 'sveltestrap';

  const colors= ['primary','secondary','success','danger','warning','info','light','dark'];

  const classes= ['function','action'];

</script>

<h3>BEXIS2 </h3>

{#each classes as c}
  <Button class="b2-button {c}">{c}</Button><br/>
{/each}

<h3>Sveltestrap with bexis class</h3>

{#each classes as c}
  <Button class="{c}">{c}</Button> <br/>
{/each}

<h3>Sveltestrap</h3>

{#each colors as c}
  <Button color="{c}">{c}</Button> <br/>
{/each}


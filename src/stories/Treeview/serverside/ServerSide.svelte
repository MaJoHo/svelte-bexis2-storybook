<script>
	import { Treeview }  from '@bexis2/svelte-bexis2-core-ui';
	import { Spinner } from 'sveltestrap';
 import { onMount } from 'svelte';

 // create a dynamic vaiable the will be updated after a async data fetch
	// if this var is updated also the ui components belong to this will be updated
	$:tv="";

	// when this components will be added to the DOM onMount will be triggered
	onMount(async () => {

		const url = 'https://localhost:44345/uitest/TreeviewData';
		const res = await fetch(url);
		tv = await res.json();
		
	});

	async function onClickHandler(e)
	{
   // value of the selected iten
			console.log(e.detail);

			//url to server action with the value of the selected item
			const url = 'https://localhost:44345/'+tv.href+"/"+e.detail;
			//fetch data
			const res = await fetch(url);

			//output status 
			console.log(await res.status);

	}
</script>

{#if tv} <!--if data is loaded, load also the tree -->
	<Treeview {...tv}
		on:selectItem={onClickHandler} 
		on:selectcheckbox={onClickHandler} />
{:else} <!-- while data is not loaded show a loading information -->
		<Spinner color="primary" />
{/if}



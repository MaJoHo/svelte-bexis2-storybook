<script>
 import jQuery from 'jquery'
 import 'datatables.net'
 import { onMount } from 'svelte'

let el;

 onMount(() => {
   jQuery(el).DataTable()
 })



</script>

<svelte:head>
	<link rel="stylesheet" href="//cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css" />
</svelte:head>


<table bind:this={el} class="display" style="width:100%">
 <thead>
   <tr>
     <th>Name</th>
     <th>Scientific Name</th>
     <th>Type</th>
     <th>Taxon</th>
   </tr>
 </thead>
 <tbody>
   <tr>
    <td>Basilikum</td>
    <td>Ocimum basilicum</td>
    <td>Plant</td>
    <td>Species</td>
   </tr>
   <tr>
    <td>Siebenpunkt-Marienkäfer</td>
    <td>Coccinella septempunctata</td>
    <td>Animal</td>
    <td>Species</td>
   </tr>
   <tr>
    <td>Kohlrabi Gigant</td>
    <td>Brassica oleracea var. gongylodes "Gigant"</td>
    <td>Plant</td>
    <td>Sub Species</td>
   </tr>
 </tbody>
 <tfoot>
   <tr>
    <th>Name</th>
    <th>Scientific Name</th>
    <th>Type</th>
    <th>Taxon</th>
   </tr>
 </tfoot>
</table>
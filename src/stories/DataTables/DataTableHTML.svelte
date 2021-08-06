<script>
	import jQuery from 'jquery'
	import { onMount, tick } from 'svelte'
	import { load } from './data.js'
    import { Button } from "sveltestrap";
    import { library } from '@fortawesome/fontawesome-svg-core';
    import { fas } from '@fortawesome/free-solid-svg-icons';
   // import { far } from '@fortawesome/free-regular-svg-icons';
  //  import { fab } from '@fortawesome/free-brands-svg-icons';
    import { FontAwesomeIcon } from 'fontawesome-svelte';
    library.add(fas);

	let el // table element
	let table // table object (API)

	const dataPromise = load()

	onMount(() => {
		dataPromise.then(tick).then(() => {
			table = jQuery(el).DataTable({
            "autoWidth": false,
            ordering: true,
            order: [[2, "asc"]], // order by startDate
            paging: false,
            responsive: true,
            "columns": [
                { "width": "30%" },
                { "width": "40%" },
                null,
                null,
                null,
                null

            ],
            columnDefs: [
                {
                    targets: 1,
                    render: jQuery.fn.dataTable.render.ellipsis(60, true)
                }]
        })
		})
	})

    jQuery.fn.dataTable.render.ellipsis = function ( cutoff, wordbreak, escapeHtml ) {
    var esc = function ( t ) {
        return t
            .replace( /&/g, '&amp;' )
            .replace( /</g, '&lt;' )
            .replace( />/g, '&gt;' )
            .replace( /"/g, '&quot;' );
    };

    return function ( d, type, row ) {
        // Order, search and type get the original data
        if ( type !== 'display' ) {
            return d;
        }

        if ( typeof d !== 'number' && typeof d !== 'string' ) {
            return d;
        }

        d = d.toString(); // cast numbers

        if ( d.length <= cutoff ) {
            return d;
        }

        var shortened = d.substr(0, cutoff-1);

        // Find the last white space character in the string
        if ( wordbreak ) {
            shortened = shortened.replace(/\s([^\s]*)$/, '');
        }

        // Protect against uncontrolled HTML input
        if ( escapeHtml ) {
            shortened = esc( shortened );
        }

        return '<span class="ellipsis" title="'+esc(d)+'">'+shortened+'&#8230;</span>';
    };
};

</script>

<svelte:head>
	<link rel="stylesheet" href="//cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css" />
</svelte:head>

<table bind:this={el} class="display" style="width:100%">
  <thead>
    <tr>
      <th>Name</th>
      <th>Position</th>
      <th>Office</th>
      <th>Age</th>
      <th>Start date</th>
      <th>Salary</th>
      <th>BUtton</th>
    </tr>
  </thead>
  <tbody>
    {#await dataPromise then rows}
      {#each rows as row}
        <tr>
          {#each row as cell}
            <td>{cell}</td>
          {/each}
          <th><Button href="test" disabled secondary size="sm"><FontAwesomeIcon icon={['fas', 'eye']} size="sm" /></Button></th>
        </tr>
      {/each}
    {/await}
  </tbody>
  <tfoot>
    <tr>
      <th>Name</th>
      <th>Position</th>
      <th>Office</th>
      <th>Age</th>
      <th>Start date</th>
      <th>Salary</th>
      <th>BUtton</th>
    </tr>
  </tfoot>
</table>

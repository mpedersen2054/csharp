
(function() {
$(document).ready(function() {
    addPokemonList()

    // handlers
    $('.poke-list__pokemons').on('click', '.poke-list__pokemon', pokemonClickHandler)
})

function addPokemonList() {
    $.each(ALL_POKEMON, function(i, poke) {
        var pokemons = $('.poke-list__pokemons'),
            upperName = poke.name.slice(0, 1).toUpperCase() + poke.name.slice(1)

        pokemons.append(`
            <li class="poke-list__pokemon" data-pokeid=${poke.id} data-pokename=${poke.name}>
                <span class="pid">${poke.id}</span>
                -
                <span class="name">${upperName}</span>
            </li>
        `)
    })
}

function pokemonClickHandler(e) {
    e.preventDefault()
    var $this = $(this),
        $pokeData = $('.poke-data'),
        $spinner = $('<div class="loading">').html('<i class="fa fa-spinner fa-spin fa-3x fa-fw"></i>')

    $pokeData.html($spinner)

    $.get(`/pokemon/${$this.data("pokeid")}`, function(data) {
        console.log('data!', data)
        $pokeData.html(pokemonDataTemplate(data))
    })
}

function pokemonDataTemplate(data) {
    var pTypes = '',
        stats = {
            hp: (data.stats[5].base_stat / 155) * 100,
            attack: (data.stats[4].base_stat / 155) * 100,
            defense: (data.stats[3].base_stat / 155) * 100,
            spattack: (data.stats[2].base_stat / 155) * 100,
            spdefense: (data.stats[1].base_stat / 155) * 100,
            speed: (data.stats[0].base_stat / 155) * 100
        }
    
    // add the types based on whether there are 1 or 2 types
    if (data.types.length < 2) {
        pTypes += `
        <div class="p-types">
            <div class="p-type1">${data.types[0].type.name}</div>
        </div>
        `
    } else {
        pTypes += '<div class="p-types">'
        for (var i = 0; i < data.types.length; i++) {
            pTypes += `<div class="p-type2">${data.types[i].type.name}</div>`
        }
        pTypes += '</div>'
    }
    return `
    <div class="top-row">
        <div class="tr-left">
            <div class="p-id">${data.id}</div>
            <div class="p-name">${data.name}</div>
            <div class="p-img">
                <img src="${data.sprites.front_default}" alt="">
            </div>
            ${pTypes}
        </div>
        <div class="tr-right">
            <div class="p-stats">
                <div class="p-stats-header">Stats</div>
                <div class="p-stat-cont">
                    <div class="p-stat-txt">
                        <span>HP</span>
                    </div>
                    <div class="p-stat">
                        <div class="p-bar p-hp" style="width:${stats.hp}%;"></div>
                    </div>
                </div>
                <div class="p-stat-cont">
                    <div class="p-stat-txt">
                        <span>HP</span>
                    </div>
                    <div class="p-stat">
                        <div class="p-bar p-attack" style="width:${stats.attack}%;"></div>
                    </div>
                </div><div class="p-stat-cont">
                    <div class="p-stat-txt">
                        <span>HP</span>
                    </div>
                    <div class="p-stat">
                        <div class="p-bar p-defense" style="width:${stats.defense}%;"></div>
                    </div>
                </div><div class="p-stat-cont">
                    <div class="p-stat-txt">
                        <span>HP</span>
                    </div>
                    <div class="p-stat">
                        <div class="p-bar p-spattack" style="width:${stats.spattack}%;"></div>
                    </div>
                </div><div class="p-stat-cont">
                    <div class="p-stat-txt">
                        <span>HP</span>
                    </div>
                    <div class="p-stat">
                        <div class="p-bar p-spdefense" style="width:${stats.spdefense}%;"></div>
                    </div>
                </div><div class="p-stat-cont">
                    <div class="p-stat-txt">
                        <span>HP</span>
                    </div>
                    <div class="p-stat">
                        <div class="p-bar p-speed" style="width:${stats.speed}%;"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="middle-row">
        More data to be added soon...
    </div>
    `
}
})()

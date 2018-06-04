# League-API
https://developer.riotgames.com/getting-started.html

The League of Legends API. It uses the official developer's API offered by Riot Games,
so you will need an API key to be able to use it.

## Examples:

```csharp
        string apikey = "[YOUR-API-KEY]";
        Region region = Region.EUW1;
        
        ApiRequest api = new ApiRequest(apikey, region);

        long summonerId = 37000721;
        int championId = 67;
        string leagueId = "14bdc992-b1c9-3cd6-a301-d6e2e52dfe39";
        
        public async Task Select_Champion_Masteries_By_Summoner_ID()
        {
            var result = await API.ChampionMasteryRequest.SelectBySummonerID(summonerId);
        }

        public async Task Get_Champion_Masteries_By_Summoner_ID_By_Champion_ID()
        {
            var result = await API.ChampionMasteryRequest.GetBySummonerIDByChampionID(summonerId, championId);
        }

        public async Task Get_Champion_Mastery_Score_By_Summoner_ID()
        {
            var result = await API.ChampionMasteryRequest.GetScoreBySummonerID(summonerId);
        }
        
        public async Task Select_Champions()
        {
            var result = await API.ChampionRequest.Select();
        }
        
        public async Task Select_Free_To_Play_Champions()
        {
            var result = await API.ChampionRequest.Select(freeToPlay: true);
        }

        public async Task Get_Champion_By_ID()
        {
            var result = await API.ChampionRequest.Get(championId);
        }
        
        public async Task Select_Challenger_League_By_Queue()
        {
            var result = await API.LeagueRequest.SelectChallengerLeagueByQueue(QueueType.RANKED_SOLO_5x5);
        }

        public async Task Select_Summoner_Leagues()
        {
            var result = await API.LeagueRequest.SelectSummonerLeagues(summonerId);
        }

        public async Task Get_League_By_ID()
        {
            var result = await API.LeagueRequest.Get(leagueId);
        }

        public async Task Select_Master_League_By_Queue()
        {
            var result = await API.LeagueRequest.SelectMasterLeagueByQueue(QueueType.RANKED_SOLO_5x5);
        }

        public async Task Select_Summoner_League_Positions()
        {
            var result = await API.LeagueRequest.SelectSummonerLeaguePositions(summonerId);
        }
        
        public async Task Select_Champions_Detailed()
        {
            var tags = new ChampionListTags[] { ChampionListTags.format };

            var result = await API.StaticDataRequest.SelectChampionsDetails(Locale.en_US, null, tags, false);
        }
```

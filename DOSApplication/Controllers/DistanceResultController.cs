using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSApplication.Controllers
{
    public class DistanceResultController : Controller
    {
        public ActionResult Index(Models.DistanceRequest distance)
        {
            var objService = new Api.DistanceCalculator();

            var result = objService.Calculate(distance);
            var distanceViewModel = new ViewModels.DistanceResultViewModel();
            var formatedResults = new Models.DistanceResponse.Response();
            //distanceViewModel.DistanceResponse = AutoMapper.Mapper.Map<Models.DistanceResponse.Response>(result);

            if (result != null)
            {
                if (result.Status == "OK")
                {
                    formatedResults.Status = result.Status;
                    formatedResults.OriginDestination = new List<Models.DistanceResponse.OriginDestination>();
                    for (int o = 0; o < result.OriginAddresses.Count; o++)
                    {
                        for (int d = 0; d < result.DestinationAddresses.Count; d++)
                        {
                            if (result.Rows[o].Elements[d].Status == "OK")
                            {
                                formatedResults.OriginDestination.Add(new Models.DistanceResponse.OriginDestination
                                {
                                    Origin = result.OriginAddresses[o],
                                    Destination = result.DestinationAddresses[d],
                                    Status = result.Rows[o].Elements[d].Status,
                                    Duration = new Models.DistanceResponse.Duration
                                    {
                                        Value = result.Rows[o].Elements[d].Duration.Value,
                                        Text = result.Rows[o].Elements[d].Duration.Text
                                    },
                                    Distance = new Models.DistanceResponse.Distance
                                    {
                                        Value = result.Rows[o].Elements[d].Distance.Value,
                                        Text = result.Rows[o].Elements[d].Distance.Text
                                    }
                                });
                            }
                            else
                            {
                                formatedResults.OriginDestination.Add(new Models.DistanceResponse.OriginDestination
                                {
                                    Status = result.Rows[o].Elements[d].Status,                                    
                                });
                            }
                        }
                    }
                }

            }
            distanceViewModel.DistanceResponse = formatedResults;


            return View("DistanceResult", distanceViewModel);
        }       
    }
}
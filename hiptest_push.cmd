dotnet test --logger "trx;LogFileName=results.xml"
hiptest-publisher --config-file hiptest-publisher.conf --push TestResults/results.xml --test-run-id 226958 --push-format mstest
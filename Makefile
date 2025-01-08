include .env

BUILD_PATH=./Builds

generate_unity_license: # local (osx)
	mkdir -p $(BUILD_PATH)
	cp /Library/Application\ Support/Unity/Unity_lic.ulf $(BUILD_PATH)/Unity_lic.ulf

generate_steam_config: # local (osx)
	brew install --cask steamcmd
	steamcmd +login $(STEAM_USER_NAME) +quit # ref .env
	mkdir -p $(BUILD_PATH)
	cat $(HOME)/Library/Application\ Support/Steam/config/config.vdf | base64 > $(BUILD_PATH)/config_base64.txt
